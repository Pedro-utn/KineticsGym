using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.Web;
using KinecticGym.Clases;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrototipoGym.Clases;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.Planes;
using PrototipoGym.Pantallas.TipoMovimientos;

namespace PrototipoGym.DataBase
{
    
    public class DatabaseHelper
    {
        private string connectionString;
        int concurrenciaSignalR = 0;

        //Gestor
        gestorPlan gestorPlan;
        gestorMovimientos gestorMovimientos;
        gestorCuenta cuentas;
        gestorTipoMovmientos tiposDeMovimientos;
        gestorCliente gestorCliente;

        // Constructor: Configura la cadena de conexión
        public DatabaseHelper()
        {
            getKeySQL();

        }
        private void getKeySQL() // Lee un text donde deberia de estar la key. Si no se encuentra se solicita uno.
        {
            string rutaTxt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key_sql.txt");


            // Verificar si el archivo existe
            if (File.Exists(rutaTxt))
            {
                try
                {
                    // Leer la primera línea del archivo
                    string[] lineas = File.ReadAllLines(rutaTxt);
                    if (lineas.Length > 0 && !string.IsNullOrWhiteSpace(lineas[0]))
                    {
                        // Guardar la key encontrada (puedes almacenarla en una variable de clase)
                        connectionString = lineas[0].Trim();
                    }
                    else
                    {

                        // El archivo existe pero está vacío
                        MessageBox.Show("El archivo key_sql.txt está vacío. Por favor, ingrese la clave de conexión en la primera línea del archivo.",
                                        "Clave no encontrada",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo key_sql.txt: {ex.Message}",
                                    "Error de lectura",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    MessageBox.Show(rutaTxt);
                    MessageBox.Show($"{connectionString}");

                }
            }
            else
            {
                try
                {
                    // Crear el archivo ya que no existe
                    File.WriteAllText(rutaTxt, "");

                    MessageBox.Show("Se ha creado el archivo key_sql.txt. Por favor, ingrese la clave de conexión en la primera línea del archivo.",
                                    "Archivo creado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo key_sql.txt: {ex.Message}",
                                    "Error de creación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
        // Método para abrir una conexión y devolver un objeto MySqlConnection
        private MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
                throw;
            }
            return connection;
        }

        // Método para ejecutar consultas SELECT y devolver un DataTable
        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                var dataTable = new DataTable();
                try
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                    throw;
                }

                return dataTable;
            }
        }

        // Método para ejecutar INSERT, UPDATE o DELETE
        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                    throw;
                }
            }
        }
        public bool InsertarGenCuota(DateTime fecha, string planesJson)
        {
            string query = @"
        INSERT INTO gencuota (fecha, planes)
        VALUES (@fecha, @planes);
    ";

            var parametros = new MySqlParameter[]
            {
        new MySqlParameter("@fecha", fecha),
        new MySqlParameter("@planes", planesJson)
            };

            try
            {
                int filasAfectadas = ExecuteNonQuery(query, parametros);
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"⚠️ Error al insertar la generación de cuota:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
        }

        public bool ExisteGenCuotaDelMesActual()
        {
            string query = @"
            SELECT COUNT(*) 
            FROM gencuota 
            WHERE MONTH(fecha) = MONTH(CURDATE()) 
              AND YEAR(fecha) = YEAR(CURDATE());
    ";

            try
            {
                DataTable resultado = ExecuteQuery(query);

                if (resultado.Rows.Count > 0)
                {
                    int cantidad = Convert.ToInt32(resultado.Rows[0][0]);
                    return cantidad > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar gencuota: {ex.Message}");
                return false;
            }
        }


        // Método para obtener la fecha del movimiento más reciente con tipoMovimiento = 1
        public DateTime GetFechaGenCuotaMasReciente()
        {
            // Definir la consulta SQL
            string query = @"
            SELECT fecha
            FROM movimientos
            WHERE tipoMovimiento = 1
            ORDER BY fecha DESC
            LIMIT 1;";

            // Ejecutar la consulta
            DataTable result = ExecuteQuery(query);

            // Verificar si se obtuvieron resultados
            if (result.Rows.Count > 0)
            {
                // Obtener la fecha del primer registro
                
                return Convert.ToDateTime(result.Rows[0]["fecha"]).Date;
            }
            else
            {
                // Si no hay resultados, retornar null
                return DateTime.MinValue.Date;
            }
        }

        //Metodo para extraer los datos de un DT y crear un gestorPlanes
        // esto es un simple comentario 2
        // cambio de prueba
        public int GetLastId(string tableName, string idColumnName)
        {
            // Validación básica para evitar inyección SQL
            if (!IsValidIdentifier(tableName) || !IsValidIdentifier(idColumnName))
            {
                throw new ArgumentException("Nombre de tabla o columna inválido");
            }

            string query = $"SELECT AUTO_INCREMENT FROM information_schema.TABLES " +
                          $"WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = '{tableName}'";

            using (var connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        object result = command.ExecuteScalar();

                        // Si no se puede obtener el AUTO_INCREMENT, intentamos obtener el máximo ID
                        query = $"SELECT COALESCE(MAX({idColumnName}), 0) + 1 FROM {tableName}";
                        command.CommandText = query;
                        result = command.ExecuteScalar();
                        return Convert.ToInt32(result);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener el último ID: {ex.Message}");
                        throw;
                    }
                }
            }
        }
        
        public void recibirUpdate(string tabla, string json) 
        {
            try
            {
                // Deserializar el JSON a un diccionario
                var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                if (tabla.Equals("clientes", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del cliente
                    int idCliente = Convert.ToInt32(jsonObject["id"]);

                    // Obtener el cliente existente del gestor
                    Cliente clienteExistente = gestorCliente.getCliente(idCliente);

                    if (clienteExistente == null)
                    {
                        throw new Exception($"No se encontró el cliente con ID {idCliente}");
                    }

                    // Obtener los valores antiguos
                    var oldValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonObject["old"].ToString());

                    // Comprobar si el nombre ha cambiado
                    string nombreNuevo = jsonObject["nombre"].ToString();
                    string nombreAntiguo = oldValues["nombre"].ToString();
                    if (!nombreNuevo.Equals(nombreAntiguo))
                    {
                        clienteExistente.setNombre(nombreNuevo);
                    }

                    // Comprobar si el teléfono ha cambiado (manejo de null)
                    string telefonoNuevo = jsonObject["telefono"]?.ToString() ?? string.Empty;
                    string telefonoAntiguo = oldValues["telefono"]?.ToString() ?? string.Empty;
                    if (telefonoNuevo != telefonoAntiguo)
                    {
                        clienteExistente.setTelefono(telefonoNuevo);
                    }

                    // Comprobar si el estado ha cambiado
                    bool estadoNuevo = Convert.ToBoolean(jsonObject["estado"]);
                    bool estadoAntiguo = Convert.ToBoolean(oldValues["estado"]);
                    if (estadoNuevo != estadoAntiguo)
                    {
                        clienteExistente.setEstado(estadoNuevo);
                    }

                    // Comprobar si el plan asociado ha cambiado
                    string planNuevoId = jsonObject["planAsociado"].ToString();
                    string planAntiguoId = oldValues["planAsociado"].ToString();
                    if (!planNuevoId.Equals(planAntiguoId))
                    {
                        // Obtener el nuevo plan del gestor de planes
                        int idPlanNuevo = Convert.ToInt32(planNuevoId);
                        Plan planNuevo = gestorPlan.getPlan(idPlanNuevo);

                        if (planNuevo == null)
                        {
                            throw new Exception($"No se encontró el plan con ID {idPlanNuevo}");
                        }

                        clienteExistente.setPlan(planNuevo);
                    }

                    // Nota: fechaInscripcion no se actualiza porque no hay un método set para ello
                    // Si se necesita actualizar, habría que añadir un método setPlanInscripcion a la clase Cliente
                }

                else if (tabla.Equals("movimientos", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del movimiento
                    int idMovimiento = Convert.ToInt32(jsonObject["idmovimientos"]);

                    // Obtener el movimiento existente del gestor
                    Movimiento movimiento = gestorMovimientos.getMovimiento(idMovimiento);

                    if (movimiento == null)
                    {
                        throw new Exception($"No se encontró el movimiento con ID {idMovimiento}");
                    }

                    // Obtener los valores antiguos
                    var oldValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonObject["old"].ToString());

                    // Comprobar si la fecha ha cambiado
                    string fechaStrNueva = jsonObject["fecha"].ToString();
                    string fechaStrAntigua = oldValues["fecha"].ToString();

                    DateTime fechaNueva = DateTime.Parse(fechaStrNueva);
                    DateTime fechaAntigua = DateTime.Parse(fechaStrAntigua);

                    if (fechaNueva != fechaAntigua)
                    {
                        movimiento.setFecha(fechaNueva);
                    }

                    // Comprobar si el monto ha cambiado
                    float montoNuevo = Convert.ToSingle(jsonObject["monto"]);
                    float montoAntiguo = Convert.ToSingle(oldValues["monto"]);

                    if (montoNuevo != montoAntiguo)
                    {
                        movimiento.setImporte(montoNuevo);
                        // Actualizamos la cuenta
                        movimiento.getCuentaMov().actualizarSaldo();
                    }

                    // Comprobar si es un Pago y si el medio de pago ha cambiado
                    int medioNuevo = Convert.ToInt32(jsonObject["medio"]);
                    int medioAntiguo = Convert.ToInt32(oldValues["medio"]);

                    // Si es un Pago (medio != 0), actualizamos el medio si ha cambiado
                    if (movimiento is Pago pagoModificado && medioNuevo != medioAntiguo)
                    {
                        pagoModificado.setMedio(medioNuevo);
                    }
                }

                else if (tabla.Equals("planes", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del plan
                    int idPlan = Convert.ToInt32(jsonObject["idPlanes"]);

                    // Obtener el plan existente del gestor
                    Plan planExistente = gestorPlan.getPlan(idPlan);

                    if (planExistente == null)
                    {
                        throw new Exception($"No se encontró el plan con ID {idPlan}");
                    }

                    // Obtener los valores antiguos
                    var oldValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonObject["old"].ToString());

                    // Comprobar si el nombre del plan ha cambiado
                    string nombreNuevo = jsonObject["nombrePlan"].ToString();
                    string nombreAntiguo = oldValues["nombrePlan"].ToString();

                    if (!nombreNuevo.Equals(nombreAntiguo))
                    {
                        planExistente.setNombre(nombreNuevo);
                    }

                    // Comprobar si la cuota ha cambiado
                    float cuotaNueva = Convert.ToSingle(jsonObject["cuota"]);
                    float cuotaAntigua = Convert.ToSingle(oldValues["cuota"]);
                    if (cuotaNueva != cuotaAntigua)
                    {
                        planExistente.setCuota(cuotaNueva);
                    }

                    // Comprobar si la descripción ha cambiado (manejo de null)
                    string descripcionNueva = jsonObject["descripcionPlan"]?.ToString() ?? string.Empty;
                    string descripcionAntigua = oldValues["descripcionPlan"]?.ToString() ?? string.Empty;

                    if (!descripcionNueva.Equals(descripcionAntigua))
                    {
                        planExistente.setDescripcion(descripcionNueva);
                    }

                    // Comprobar si el estado ha cambiado
                    bool estadoNuevo = Convert.ToBoolean(jsonObject["estado"]);
                    bool estadoAntiguo = Convert.ToBoolean(oldValues["estado"]);
                    if (estadoNuevo != estadoAntiguo)
                    {
                        planExistente.setEstado(estadoNuevo);
                    }
                }


                else if (tabla.Equals("tipomovimiento", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del tipo de movimiento
                    int idTipoMovimiento = Convert.ToInt32(jsonObject["idTipoMovimiento"]);

                    // Obtener el tipo de movimiento existente del gestor
                    TipoMovmiento tipoMovimientoExistente = tiposDeMovimientos.getTipoMov(idTipoMovimiento);

                    if (tipoMovimientoExistente == null)
                    {
                        throw new Exception($"No se encontró el tipo de movimiento con ID {idTipoMovimiento}");
                    }

                    // Obtener los valores antiguos
                    var oldValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonObject["old"].ToString());

                    // Comprobar si el detalle ha cambiado
                    string detalleNuevo = jsonObject["detalle"].ToString();
                    string detalleAntiguo = oldValues["detalle"].ToString();
                    if (!detalleNuevo.Equals(detalleAntiguo))
                    {
                        tipoMovimientoExistente.setDetalle(detalleNuevo);
                    }

                    // Comprobar si el tipo (ingreso/egreso) ha cambiado
                    bool tipoNuevo = Convert.ToBoolean(jsonObject["tipo"]);
                    bool tipoAntiguo = Convert.ToBoolean(oldValues["tipo"]);
                    if (tipoNuevo != tipoAntiguo)
                    {
                        tipoMovimientoExistente.setTipo(tipoNuevo);
                    }

                    // Comprobar si el estado ha cambiado
                    bool estadoNuevo = Convert.ToBoolean(jsonObject["estado"]);
                    bool estadoAntiguo = Convert.ToBoolean(oldValues["estado"]);
                    if (estadoNuevo != estadoAntiguo)
                    {
                        tipoMovimientoExistente.setEstado(estadoNuevo);
                    }


                }

                else
                {
                    throw new ArgumentException($"Tabla no soportada para actualización: {tabla}");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al procesar la actualización para la tabla {tabla}: {ex.Message}");
                // Podrías también registrar el error, lanzar una excepción personalizada, etc.
                throw;
            }
        }
        public void recibirInsert( string tabla, string json)
        {
            // Deserializar el JSON a un diccionario


            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            // Determinar qué tipo de objeto crear basado en el parámetro tipoConversion
            if (tabla.Equals("movimientos", StringComparison.OrdinalIgnoreCase))
            {
                Movimiento movimiento;  

                // Obtener los valores del JSON
                int medioPago = Convert.ToInt32(jsonObject["medio"]);               
                int idMovimiento = Convert.ToInt32(jsonObject["idmovimientos"]);
                float monto = Convert.ToSingle(jsonObject["monto"]);
                int tipoMovimientoId = Convert.ToInt32(jsonObject["tipoMovimiento"]);
                string fechaStr = jsonObject["fecha"].ToString();
                int idCuenta = Convert.ToInt32(jsonObject["idCuentaMovimientos"]);
                // Convertir la cadena de fecha a DateTime
                DateTime fecha = DateTime.Parse(fechaStr);

                Cuenta cuentaMov = cuentas.getCuenta(idCuenta);
                TipoMovmiento tipoMovimiento = tiposDeMovimientos.getTipoMov(tipoMovimientoId);

                if (medioPago != 0)
                {
                    movimiento = new Pago(cuentaMov,idMovimiento,monto,tipoMovimiento,medioPago);

                } 
                else
                {
                    movimiento = new Movimiento(cuentaMov,idMovimiento,monto,tipoMovimiento);
                }

                gestorMovimientos.addMovmiento(movimiento);
            }
             else if (tabla.Equals("clientes", StringComparison.OrdinalIgnoreCase))
            {

                int idCliente = Convert.ToInt32(jsonObject["id"]);
                string nombre = jsonObject["nombre"].ToString();
                string telefono = jsonObject["telefono"] != null ? jsonObject["telefono"].ToString() : string.Empty;
                int planId = Convert.ToInt32(jsonObject["planAsociado"]);
                string fechaStr = jsonObject["fechaInscripcion"]?.ToString();
                DateTime fecha = DateTime.MinValue; // Valor predeterminado en caso de error
                if (!string.IsNullOrEmpty(fechaStr) && DateTime.TryParse(fechaStr, out DateTime fechaParseada))
                {
                    fecha = fechaParseada;
                }

                // Crear cuenta
                Cuenta cuentaNueva = new Cuenta(idCliente);
                cuentas.addCuenta(cuentaNueva);

                Plan plan = gestorPlan.getPlan(planId);

                Cliente clienteNuevo = new Cliente(idCliente,nombre,telefono,plan,cuentaNueva,true,fecha);

                gestorCliente.cargarCliente(clienteNuevo);

            }

            else if (tabla.Equals("planes", StringComparison.OrdinalIgnoreCase))// public Plan(string nombre, bool estado, string descripcion, string monto, int idPlan)

            {
                float importe = Convert.ToSingle(jsonObject["cuota"]);
                bool estado = Convert.ToBoolean(jsonObject["estado"]);
                int idPlan = Convert.ToInt32(jsonObject["idPlanes"]);
                string nombrePlan = (jsonObject["nombrePlan"]).ToString();
                string descripcion = jsonObject["descripcionPlan"]?.ToString() ?? string.Empty;

                Plan nuevoPlan = new Plan(nombrePlan,estado,descripcion,importe.ToString(),idPlan);

                gestorPlan.cargarPlan(nuevoPlan);
            }
            else if (tabla.Equals("tipomovimiento", StringComparison.OrdinalIgnoreCase))
            {
                bool tipo = Convert.ToBoolean(jsonObject["tipo"]);
                bool estado = Convert.ToBoolean(jsonObject["estado"]);
                string detalle = (jsonObject["detalle"]).ToString();
                int idTipoMovimiento = Convert.ToInt32(jsonObject["idTipoMovimiento"]);

                TipoMovmiento nuevoTipo = new TipoMovmiento(detalle,idTipoMovimiento,tipo,estado);

                tiposDeMovimientos.addTipo(nuevoTipo);

            }
            else
            {
                MessageBox.Show("Tabla no encontrado. SignalR");
            }


        }

        public void recibirDelete(string tabla,string json)
        {
            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            if (tabla.Equals("movimientos", StringComparison.OrdinalIgnoreCase))
            {
                int idMov = Convert.ToInt32(jsonObject["idmovimientos"]);

                gestorMovimientos.eliminarMovimiento(gestorMovimientos.getMovimiento(idMov));

            }
            else if (tabla.Equals("clientes", StringComparison.OrdinalIgnoreCase))
            {
                int idCLiente = Convert.ToInt32(jsonObject["clientes"]);

                gestorCliente.eliminateCliente(idCLiente);

            }



        }

        private bool IsValidIdentifier(string identifier)
        {
            if (string.IsNullOrWhiteSpace(identifier))
                return false;

            // Verificar que solo contenga caracteres alfanuméricos y guiones bajos
            return System.Text.RegularExpressions.Regex.IsMatch(identifier, @"^[a-zA-Z0-9_]+$");
        }


        public gestorPlan CargarPlanesDeSQL(DataTable dataTable)
        {
            gestorPlan = new gestorPlan();

            foreach (DataRow row in dataTable.Rows)
            {

                int idPlan = Convert.ToInt32(row["idplanes"]);
                string nombrePlan = (string)row["nombrePlan"];
                string descripcion = row["descripcionPlan"] == DBNull.Value ? "" : (string)row["descripcionPlan"];
                string cuota = row["cuota"] != DBNull.Value ? ((float)row["cuota"]).ToString() : string.Empty;
                bool estado = (Convert.ToInt32(row["estado"]) != 0); // si el valor que devuelve el dato en estado osea "0" o "1" al convertirse a entero es distinto de 0 el valor sera true

                Plan planLeido = new Plan(nombrePlan, estado, descripcion, cuota, idPlan);
                gestorPlan.cargarPlan(planLeido);

            }
            return (gestorPlan);

        }



        public gestorMovimientos CargarMovimientosSQl(DataTable dataTable, gestorTipoMovmientos tiposMovmientos, gestorCuenta cuentas)
        {
            gestorMovimientos = new gestorMovimientos();
            foreach (DataRow row in dataTable.Rows)
            {
                int idCuentaMovimiento = Convert.ToInt32(row["idCuentaMovimientos"]);
                int idMovimiento = Convert.ToInt32(row["idmovimientos"]);
                float monto = Convert.ToSingle(row["monto"]);
                int idTipoMovid = Convert.ToInt32(row["tipoMovimiento"]);
                TipoMovmiento tipoMov = tiposMovmientos.getTipoMov(idTipoMovid);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
                Cuenta cuenta = cuentas.getCuenta(idCuentaMovimiento);
                int medio = Convert.ToInt32(row["medio"]);

                Movimiento movimientoLeido;
                if (medio == 0)
                {
                    movimientoLeido = new Movimiento(cuenta, idMovimiento, monto, tipoMov, fecha);
                }
                else
                {
                    movimientoLeido = new Pago(cuenta, idMovimiento, monto, tipoMov, fecha, medio);
                }

                cuenta.addMovimiento(movimientoLeido);
                gestorMovimientos.addMovmiento(movimientoLeido);
            }
            return gestorMovimientos;
        }

        public gestorCuenta CargarCuentasSQL(DataTable dataTable)
        {
            cuentas = new gestorCuenta();
            foreach (DataRow row in dataTable.Rows)
            {
                int idCuenta = Convert.ToInt32(row["idcuentas"]);

                Cuenta cuentaLeida = new Cuenta(idCuenta);

                cuentas.addCuenta(cuentaLeida);

            }
            return (cuentas);

        }

        public void eliminarMovimiento(Movimiento movimiento, float saldoModificado)
        {

            //Se eliminar el movimiento

            string query = @"DELETE FROM movimientos WHERE idmovimientos = @idmovimientos
";
            MySqlParameter[] parameters = new MySqlParameter[]
               { new MySqlParameter(@"idmovimientos", movimiento.getId()) };
            try
            {
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar movimiento: {ex.Message}");
                throw;
            }

            // Se modifica el saldo

            query = @"UPDATE cuentas 
                    SET 
                        saldo = @saldo
                    WHERE idcuentas = @idcuentas";

            parameters = new MySqlParameter[]
            {
            new MySqlParameter("@saldo", saldoModificado),
            new MySqlParameter("@idcuentas", movimiento.getCuentaMov().getIdCuenta())  // Añadido este parámetro
            };

            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el saldo de cuenta: {ex.Message}");
                throw;
            }


        }

        public gestorCliente CagarClientesSQL(DataTable dataTable, gestorPlan planes, gestorCuenta cuentas)
        {
            gestorCliente = new gestorCliente();
            foreach (DataRow row in dataTable.Rows)
            {
                int idCliente = Convert.ToInt32(row["id"]);
                string nombre = (string)row["nombre"];
                string telefono = row["telefono"] == DBNull.Value ? "" : (string)row["telefono"];
                Plan planAsociado = planes.getPlan(Convert.ToInt32(row["planAsociado"]));
                bool estado = (Convert.ToInt32(row["estado"]) != 0); // si el valor que devuelve el dato en estado osea "0" o "1" al convertirse a entero es distinto de 0 el valor sera true
                DateTime fechaInscripcion = row["fechaInscripcion"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["fechaInscripcion"]);
                Cuenta cuentaAsociada = cuentas.getCuenta(idCliente);

                //GestorCuenta.getCuenta
                Cliente clienteLeido = new Cliente(idCliente, nombre, telefono, planAsociado, cuentaAsociada, estado, fechaInscripcion);
                gestorCliente.cargarCliente(clienteLeido);


            }
            return (gestorCliente);

        }
        public gestorTipoMovmientos CargarTiposDeMovimientosSQL(DataTable dataTable)
        {
            tiposDeMovimientos = new gestorTipoMovmientos(this);
            foreach (DataRow row in dataTable.Rows)
            {
                int idTipoMovmiento = Convert.ToInt32(row["idTipoMovimiento"]);
                string detalle = (string)row["detalle"];
                bool tipo = (Convert.ToInt32(row["tipo"]) != 0);
                bool estado = (Convert.ToInt32(row["estado"]) != 0);

                TipoMovmiento tipoMovLeido = new TipoMovmiento(detalle, idTipoMovmiento, tipo, estado);
                tiposDeMovimientos.addTipo(tipoMovLeido);
            }

            return tiposDeMovimientos;
        }

        public void InsertarCliente(Cliente cliente)
        {
            string query = @"INSERT INTO clientes (id, nombre, telefono, planAsociado, estado, fechaInscripcion) 
                    VALUES (@id, @nombre, @telefono, @planAsociado, @estado, @fechaInscripcion)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", cliente.getId()),
                new MySqlParameter("@nombre", cliente.getNombre()),
                new MySqlParameter("@telefono", cliente.getTelefono()),
                new MySqlParameter("@planAsociado", cliente.getPlanAsociado().getIdPlan()),
                new MySqlParameter("@estado", cliente.getEstado() ? 1 : 0),
                new MySqlParameter("@fechaInscripcion",cliente.getFechaInscripcion())
            };

            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar cliente: {ex.Message}");
                throw;
            }
        }
        public void InsertarPlan(Plan plan)
        {
            string query = @"INSERT INTO planes (idplanes, nombrePlan, descripcionPlan, cuota, estado) 
                   VALUES (@idPlan, @nombre, @descripcion, @cuota, @estado)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
               new MySqlParameter("@idPlan", plan.getIdPlan()),
               new MySqlParameter("@nombre", plan.getNombrePlan()),
               new MySqlParameter("@descripcion", plan.getDescription()),
               new MySqlParameter("@cuota", plan.getCuota()),
               new MySqlParameter("@estado", plan.getEstado() ? 1 : 0)
            };

            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar plan: {ex.Message}");
                throw;
            }
        }
        public void modificarCliente(Cliente cliente)
        {
            string query = @"UPDATE clientes 
            SET 
                nombre = @nombre,
                telefono = @telefono,
                planAsociado = @idPlan,
                estado = @estado
            WHERE id = @idCliente";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nombre", cliente.getNombre()),
                new MySqlParameter("@telefono", cliente.getTelefono()),
                new MySqlParameter("@idPlan", cliente.getPlanAsociado().getIdPlan()),
                new MySqlParameter("@estado", cliente.getEstado()),
                new MySqlParameter("@idCliente", cliente.getId()),

            };
            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modifcar cliente: {ex.Message}");
                throw;
            }
        }

        public void modificarPlan(Plan plan)
        {
            string query = @"UPDATE planes 
            SET 
                nombrePlan = @nombrePlan,
                descripcionPlan = @descripcionPlan,
                cuota = @cuota,
                estado = @estado
            WHERE idplanes = @idplanes";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nombrePlan", plan.getNombrePlan()),
                new MySqlParameter("@descripcionPlan", plan.getDescription()),
                new MySqlParameter("@cuota", plan.getCuota()),
                new MySqlParameter("@estado", plan.getEstado()),
                new MySqlParameter("@idplanes", plan.getIdPlan()),
            };
            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificarPlan: {ex.Message}");
                throw;
            }
        }
        public void modificarTipoMovimiento(TipoMovmiento tipoMovimiento)
        {
            string query = @"UPDATE tipomovimiento 
            SET 
                detalle = @detalle,
                tipo = @tipo,
                estado = @estado
            WHERE idtipoMovimiento = @idtipoMovimiento";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@detalle", tipoMovimiento.getDetalle()),
                new MySqlParameter("@tipo", tipoMovimiento.getTipoBool()),
                new MySqlParameter("@estado",tipoMovimiento.getEstado()),
                new MySqlParameter("@idtipoMovimiento", tipoMovimiento.getId()),

            };
            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR  ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar TipoMviento: {ex.Message}");
                throw;
            }
        }

        public void deleteTipoMovimiento(TipoMovmiento tipoMovimiento)
        {
            string query = @"DELETE FROM tipomovimiento
            WHERE idtipoMovimiento = @idtipomovimiento";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@idtipomovimiento", tipoMovimiento.getId())
            };
            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar TipoMovimiento: {ex.Message}");
                throw;
            }

        }


        public void InsertarCuenta(Cuenta cuenta)
        {
            string query = @"INSERT INTO cuentas (idcuentas, saldo) 
                    VALUES (@idCuenta, @saldo)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@idCuenta", cuenta.getIdCuenta()),
                new MySqlParameter("@saldo", cuenta.getSaldo()) // El saldo inicia en 0 para una nueva cuenta
            };

            try
            {
                ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar cuenta: {ex.Message}");
                throw;
            }
        }
        public void insertarTipoMovimiento(TipoMovmiento tipoMovimientoNuevo)
        {
            string query = @"INSERT INTO tipomovimiento (idtipoMovimiento, detalle,tipo,estado) 
                    VALUES (@idTipoMov, @detalle,@tipo,@estado)";
            MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter ("@idTipoMov",tipoMovimientoNuevo.getId()),
                    new MySqlParameter ( "@detalle", tipoMovimientoNuevo.getDetalle()),
                    new MySqlParameter ("@tipo", tipoMovimientoNuevo.getTipoBool()),
                    new MySqlParameter ("@estado",tipoMovimientoNuevo.getEstado())
                };
            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar tipoMovimientoNuevo: {ex.Message}");
                throw;
            }

        }
        public void insertarMovmiento(Movimiento movimientoNuevo)
        {
            string query = @"INSERT INTO movimientos (idmovimientos,monto,idCuentaMovimientos,fecha,tipoMovimiento,medio)
                  VALUES (@idMovimiento,@monto,@idCuenta,@fecha,@tipoMovmiento,@medio)";

            // Determinar el valor de medio según el tipo de movimiento
            int medio = 0; // Valor por defecto para movimientos normales
            if (movimientoNuevo is Pago pago)
            {
                medio = pago.getMedioPago();
            }

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter ("@idMovimiento",movimientoNuevo.getId()),
                new MySqlParameter ("@monto",movimientoNuevo.getMonto()),
                new MySqlParameter ("@idCuenta",movimientoNuevo.getCuentaMov().getIdCuenta()),
                new MySqlParameter ("@fecha",movimientoNuevo.getFecha()),
                new MySqlParameter ("@tipoMovmiento",movimientoNuevo.getTipo().getId()),
                new MySqlParameter ("@medio", medio),
            };

            try
            {
                ExecuteNonQuery(query, parameters);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar movimiento: {ex.Message}");
                throw;
            }
        }

        public void actualizarSaldoCuenta(Cuenta cuentaModificada)
        {
            // Consulta SQL para actualizar el saldo
            string query = @"UPDATE cuentas 
                     SET saldo = @nuevoSaldo 
                     WHERE idcuentas = @idCuenta";

            // Parámetros de la consulta
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nuevoSaldo", cuentaModificada.getSaldo()),
                new MySqlParameter("@idCuenta", cuentaModificada.getIdCuenta())
            };

            try
            {
                // Ejecutar la consulta
                int filasAfectadas = ExecuteNonQuery(query, parameters);

                // Verificar si se actualizó alguna fila
                if (filasAfectadas == 0)
                {
                    Console.WriteLine($"No se encontró ninguna cuenta con ID {cuentaModificada.getIdCuenta()} para actualizar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el saldo de la cuenta: {ex.Message}");
                throw;
            }
        }
        public DataTable generateResumenCuentaDt(int idCuenta, DateTime fechaDesde, DateTime fechaHasta, float saldoAnterior)
        {
            // Crear DataTable con un nombre específico
            DataTable dtResumen = new DataTable("DataTableCuenta");
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Primero obtenemos el saldo inicial
                    decimal saldoInicial = 0;
                    string querySaldoInicial = "SELECT saldo FROM cuentas WHERE idCuentas = @idCuenta";
                    using (MySqlCommand cmdSaldoInicial = new MySqlCommand(querySaldoInicial, connection))
                    {
                        cmdSaldoInicial.Parameters.AddWithValue("@idCuenta", idCuenta);
                        object result = cmdSaldoInicial.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            saldoInicial = Convert.ToDecimal(result);
                        }
                    }
                    // Creamos la consulta principal para el resumen con los nuevos nombres de columna
                    string query = @"
            SELECT
                m.fecha AS Fecha,
                m.idmovimientos AS Nro,
                m.tipoMovimiento AS TipoMovimiento,
                CASE 
                    WHEN m.medio = 1 THEN 'Pago Cuota - Efectivo'
                    WHEN m.medio = 2 THEN 'Pago Cuota - Transferencia'
                    ELSE tm.detalle
                END AS Detalle,
                CASE WHEN tm.tipo = false THEN m.monto ELSE 0 END AS Debitos,
                CASE WHEN tm.tipo = true THEN m.monto ELSE 0 END AS Reditos
                
            FROM movimientos AS m
            JOIN tipomovimiento AS tm
            ON m.tipoMovimiento = tm.idTipoMovimiento
            WHERE m.idCuentaMovimientos = @idCuentaMovimientos
            AND m.fecha BETWEEN @fechaDesde AND @fechaHasta
            ORDER BY m.fecha;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCuentaMovimientos", idCuenta);
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.ToString("yyyy-MM-dd"));
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtResumen);
                        }

                        // Modificar el detalle para tipoMovimiento = 1
                        foreach (DataRow row in dtResumen.Rows)
                        {
                            if (Convert.ToInt32(row["TipoMovimiento"]) == 1)
                            {
                                // Obtener la fecha y convertirla al formato de mes en texto
                                DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                                string nombreMes = fecha.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                                // Primera letra en mayúscula
                                nombreMes = char.ToUpper(nombreMes[0]) + nombreMes.Substring(1);
                                row["Detalle"] = $"Generación Cuota - {nombreMes}";
                            }
                        }

                        // Eliminar la columna TipoMovimiento ya que solo la usamos internamente
                        dtResumen.Columns.Remove("TipoMovimiento");

                        // Agregar la columna Saldo al DataTable
                        dtResumen.Columns.Add("Saldo", typeof(decimal));
                        // Calcular el saldo acumulado
                        float saldoRow = saldoAnterior;
                        foreach (DataRow row in dtResumen.Rows)
                        {
                            saldoRow -= Convert.ToSingle(row["Debitos"]);
                            saldoRow += Convert.ToSingle(row["Reditos"]);
                            row["Saldo"] = saldoRow;
                        }
                        //Se ajusta el formato fecha
                    
                    }

                }
                // Guardar el esquema XML (opcional)
                string relativePath = @"Reportes\DataTableCuenta.xsd";
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

                dtResumen.WriteXmlSchema(fullPath);
                return dtResumen;
            }
            catch (Exception ex)
            {
                // En un entorno de producción, considera registrar la excepción
                Console.WriteLine($"Error al generar el resumen de cuenta: {ex.Message}");
                throw;
            }
        }




        public DataTable crearSaldoClienteTable(DateTime fecha)
        {
            // Crear DataTable con un nombre específico
            DataTable dtSaldosNegativos = new DataTable("DataTableSaldosNegativos");
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener saldos negativos SOLO de clientes ACTIVOS (estado = 1)
                    string query = @"
            SELECT 
                c.id AS Id,
                c.nombre AS Nombre,
                c.telefono AS Telefono,
                SUM(
                    CASE 
                        WHEN tm.tipo = true THEN m.monto
                        WHEN tm.tipo = false THEN -m.monto
                        ELSE 0
                    END
                ) AS Saldo
            FROM 
                clientes c
            LEFT JOIN 
                movimientos m ON c.id = m.idCuentaMovimientos AND m.fecha <= @fechaConsulta
            LEFT JOIN
                tipomovimiento tm ON m.tipoMovimiento = tm.idTipoMovimiento
            WHERE
                c.estado = 1 -- Solo clientes activos
            GROUP BY 
                c.id, c.nombre, c.telefono
            HAVING 
                Saldo < 0
            ORDER BY 
                Saldo ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fechaConsulta", fecha.ToString("yyyy-MM-dd"));

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtSaldosNegativos);
                        }
                    }

                    // Opcional: guardar el esquema XML
                    string relativePath = @"Reportes\DataTableSaldosNegativos.xsd";
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

                    // Asegúrate de que el directorio exista
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

                    dtSaldosNegativos.WriteXmlSchema(fullPath);
                }

                return dtSaldosNegativos;
            }
            catch (Exception ex)
            {
                // En un entorno de producción, considera registrar la excepción
                Console.WriteLine($"Error al obtener los clientes con saldo negativo: {ex.Message}");
                throw;
            }
        }
        public DataTable crearClientesActivosTable(gestorCliente clienteGestor)
        {
            List<Cliente> clientes = clienteGestor.getClienteList();
            DataTable table = new DataTable();

            table.Columns.Add("Nro", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Telefono", typeof(string));

            foreach (Cliente cliente in clientes)
            {
                if (cliente.getEstado())
                {
                    table.Rows.Add(cliente.getId(), cliente.getNombre(), cliente.getTelefono());
                }
            }
            return table;

        }

        public DataTable generateTablaCajaDiaria(gestorMovimientos gestorMovimientos, DateTime desde, DateTime hasta)  // Solo efectivo
        {
            List<Pago> pagos = gestorMovimientos.getPagosList();
            DataTable table = new DataTable();

            table.Columns.Add("Nro", typeof(int));
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Cliente",typeof(string));
            table.Columns.Add("Detalle", typeof(string));
            table.Columns.Add("Medio", typeof(string));
            table.Columns.Add("Importe", typeof(float));

            foreach (Pago pago in pagos)
            {
                if (pago.getFecha().Date >= desde.Date && pago.getFecha().Date <= hasta.Date)
                {
                    table.Rows.Add(pago.getId(), pago.getFecha().Date,gestorCliente.getCliente(pago.getCuentaMov().getIdCuenta()).getNombre(), pago.getTipo().getDetalle(),
                    (pago.getMedioPago() == 1 ? "Efectivo" : pago.getMedioPago() == 2 ? "Transferencia" : "Desconocido"), pago.getImporteFloat());
                }
            }
            return table;
        }
        public void modificarMovimiento(Movimiento movimiento)
        {
            string query = @"UPDATE movimientos 
        SET 
            fecha = @fecha,
            monto = @monto,
            medio = @medio
        WHERE idmovimientos = @id";

            List<MySqlParameter> parameters = new List<MySqlParameter>
        {
                new MySqlParameter("@fecha", movimiento.getFecha()),
                new MySqlParameter("@monto", movimiento.getMonto()),
                new MySqlParameter("@medio",(movimiento is Pago pago) ? (int?)pago.getMedioPago() ?? 0 : 0), // Evita null
                new MySqlParameter("@id", movimiento.getId())
        };

            

            MySqlParameter[] parametersArray = parameters.ToArray();
            try
            {
                ExecuteNonQuery(query, parametersArray);
                concurrenciaSignalR ++;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar movimiento: {ex.Message}");
                throw;
            }

            // Actualizar la cuenta asociada
            query = @"UPDATE cuentas 
        SET 
            saldo = @saldo
        WHERE idcuentas = @idcuentas";

            List<MySqlParameter> parametersAccount = new List<MySqlParameter>
        {
            new MySqlParameter("@saldo", movimiento.getCuentaMov().getSaldo()),
            new MySqlParameter("@idcuentas", movimiento.getCuentaMov().getIdCuenta())
    };

            MySqlParameter[] parametersAccountArray = parametersAccount.ToArray();
            try
            {
                ExecuteNonQuery(query, parametersAccountArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cuenta: {ex.Message}");
                throw;
            }
        }

        public float getTotalRecaudado(gestorMovimientos movimientosGestor)
        {
            List<Pago> pagos = movimientosGestor.getPagosList();
            float totalRecaudado = 0;
            foreach (Movimiento pago in pagos)
            {
                totalRecaudado += pago.getImporteFloat();
            }
            return totalRecaudado;
        }

        public int evaluarConcurrenciaSignalR()
        {
            int estado = concurrenciaSignalR;

            if (concurrenciaSignalR !=0)
            {
                concurrenciaSignalR--;
            }
            return estado;
        }

    }


}