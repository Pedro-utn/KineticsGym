using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinecticGym.Pantallas;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.Pantallas;
using PrototipoGym.Pantallas.Movimientos;
using PrototipoGym.Pantallas.Planes;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace KinecticGym.DataBase
{
    public class ActualizacionesSignalR
    {
        private HubConnection _connection;
        private readonly string _hubUrl;
        DatabaseHelper dbHelper;

        //Pantallas
        MovimientosMain movimientosMainForm;
        TipoMovimientosMain tipoMovMainForm;
        planesMain planesMainForm;
        Clientes clientesForm;
        principal principalForm;


        public ActualizacionesSignalR(DatabaseHelper dbHelper, TipoMovimientosMain tipoMovFormMain,MovimientosMain movimeintosMain,planesMain planesmain, Clientes clientesform, principal principalForm)
        {
            this.movimientosMainForm = movimeintosMain;
            this.planesMainForm = planesmain;
            this.clientesForm = clientesform;
            this.tipoMovMainForm = tipoMovFormMain;
            this.principalForm = principalForm;

            this.dbHelper = dbHelper;
            _hubUrl = ObtenerUrlDesdeArchivo();
            InitializeConnection();
        }

        private string ObtenerUrlDesdeArchivo()
        {
            try
            {
                // Ruta del archivo en el mismo directorio que la aplicación
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "urls.txt");
                
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show($"No se encontró el archivo de configuración en: {rutaArchivo}", 
                                    "Error de configuración", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                    return "http://192.168.14.149:5000/signalr"; // URL por defecto en caso de error
                }

                // Leer la primera línea del archivo
                string url = File.ReadLines(rutaArchivo).FirstOrDefault();
                
                if (string.IsNullOrWhiteSpace(url))
                {
                    MessageBox.Show("El archivo de configuración está vacío.",
                                    "Error de configuración",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return "http://192.168.14.149:5000/signalr"; // URL por defecto en caso de error
                }

                // Trim para eliminar espacios o caracteres no deseados
                url = url.Trim();
                
                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de configuración: {ex.Message}",
                                "Error de configuración",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return "http://192.168.14.149:5000/signalr"; // URL por defecto en caso de error
            }
        }

        private void InitializeConnection()
        {
            try
            {
                // Configuración de SignalR
                _connection = new HubConnectionBuilder()
                    .WithUrl(_hubUrl, options =>
                    {
                        // Permitir certificados no válidos para desarrollo
                        options.HttpMessageHandlerFactory = handler =>
                        {
                            if (handler is HttpClientHandler clientHandler)
                            {
                                clientHandler.ServerCertificateCustomValidationCallback =
                                    (message, cert, chain, errors) => true;
                            }
                            return handler;
                        };

                        // Permitir todos los transportes disponibles en orden de preferencia
                        options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets |
                                           Microsoft.AspNetCore.Http.Connections.HttpTransportType.ServerSentEvents |
                                           Microsoft.AspNetCore.Http.Connections.HttpTransportType.LongPolling;
                        
                        // No forzar a saltarse la negociación
                        options.SkipNegotiation = false;
                    })
                    .WithAutomaticReconnect(new[] { 
                        TimeSpan.Zero, 
                        TimeSpan.FromSeconds(2), 
                        TimeSpan.FromSeconds(5),
                        TimeSpan.FromSeconds(10),
                        TimeSpan.FromSeconds(20)
                    })
                    .Build();

                RegisterEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la inicialización: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void RegisterEventHandlers()
        {
            // Registro del manejador para recibir actualizaciones
            _connection.On<string, string, string>("RecibirActualizacion", (tipoOperacion, tabla, datosJson) =>
            {
                // Usar BeginInvoke para evitar problemas de threading con UI
                if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
                {
                    Application.OpenForms[0].BeginInvoke(new Action(() =>
                    {
                  
                        // Aquí eliminamos las conversiones innecesarias
                        
                        if (dbHelper.evaluarConcurrenciaSignalR() == 0)
                        {
                            datosJson = datosJson.Trim(); // Eliminar espacios en blanco l inicio y final
                            JToken parsedJson = JToken.Parse(datosJson);
                            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(datosJson);


                            if (tipoOperacion.Equals("INSERT", StringComparison.OrdinalIgnoreCase))  //En caso de un insert se genera la instancia y lo agregan al gestor.
                            {
                                dbHelper.recibirInsert(tabla, datosJson);
                            }
                            else if (tipoOperacion.Equals("UPDATE", StringComparison.OrdinalIgnoreCase))
                            {
                                dbHelper.recibirUpdate(tabla, datosJson);
                            }
                            else if (tipoOperacion.Equals("DELETE", StringComparison.OrdinalIgnoreCase))
                            {
                                dbHelper.recibirDelete(tabla, datosJson);
                            }
                            principalForm.cargarCamposCliente();
                            


                            // Luego proceder a actualizar el respectivo grid
                            if (tabla.Equals("clientes", StringComparison.OrdinalIgnoreCase))
                            {
                                clientesForm.actualizarGrid();
                                principalForm.actualizarGrid();
                            }
                            else if (tabla.Equals("planes", StringComparison.OrdinalIgnoreCase))
                            {
                                planesMainForm.actualizarGrid();
                            }
                            else if (tabla.Equals("movimientos", StringComparison.OrdinalIgnoreCase))
                            {
                                movimientosMainForm.actualizarGrid();
                            }
                            else if (tabla.Equals("tipomovimientos", StringComparison.OrdinalIgnoreCase))
                            {
                                tipoMovMainForm.actualizarGrid();
                            }
                        }
                    }));
                }
                else
                {
                    MessageBox.Show($"Operación: {tipoOperacion}, Tabla: {tabla}, Datos: {datosJson}");
                }
            });

            // Manejadores de diagnóstico
            _connection.Closed += error =>
            {
                LogToUI($"Conexión cerrada: {error?.Message ?? "Sin detalles"}");
                return Task.CompletedTask;
            };

            _connection.Reconnecting += error =>
            {
                LogToUI($"Reconectando: {error?.Message ?? "Sin detalles"}");
                return Task.CompletedTask;
            };

            _connection.Reconnected += connectionId =>
            {
                LogToUI($"Reconectado con ID: {connectionId}");
                return Task.CompletedTask;
            };
        }


        private void LogToUI(string message)
        {
            if (Application.OpenForms.Count > 0 && Application.OpenForms[0].InvokeRequired)
            {
                Application.OpenForms[0].BeginInvoke(new Action(() =>
                {
                    MessageBox.Show(message);
                }));
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        public async Task StartConnectionAsync()
        {
            try
            {
                if (_connection.State == HubConnectionState.Disconnected)
                {
                    await _connection.StartAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con signalR");
                LogToUI($"Error al conectar a {_hubUrl}: {ex.Message}\n\nInnerException: {ex.InnerException?.Message}");
            }
        }

        public async Task StopConnectionAsync()
        {
            if (_connection != null)
            {
                await _connection.StopAsync();
                await _connection.DisposeAsync();
            }
        }

        
    }
}