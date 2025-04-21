using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinecticGym.Clases;
using Mysqlx;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Math.EC;
using PrototipoGym;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas;
using PrototipoGym.Reportes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KinecticGym.Pantallas
{
    public partial class principal : Form
    {
        //Gestores
        gestorCliente gestorCliente;
        gestorMovimientos gestorMovimientos;
        gestorPlan gestorPlan;
        gestorTipoMovmientos gestorTipoMovmientos;
        gestorCuenta gestorCuenta;
        DatabaseHelper dbHelper;

        //Atributos
        Cliente clienteModificado;
        Cliente clienteSeleccionado;
        Cliente clienteNuevo;
        Plan planSeleccionado;
        Cuenta cuentaNueva;
        Pago pago;
        Movimiento movimientoDescuento;
        Movimiento movimientoPago;
        float importePago;
        float importeDescuento;
        int medioPago = 0;


        //bool
        bool clienteNuevoEnProceso;
        bool cambioDeProceso;
        bool modificandoCliente;
        bool isUpdating = false;



        //pantallas
        BuscarCliente buscarClienteForm;
        BuscarPlan buscarPlanForm;




        public principal(gestorCliente gestorCliente, gestorMovimientos gestorMovimientos, gestorPlan gestorPlan, gestorCuenta gestorCuenta, gestorTipoMovmientos gestorTipoMovmientos, DatabaseHelper dbhelper)
        {
            InitializeComponent();

            cambiarFont();

          



            this.gestorCliente = gestorCliente;
            this.gestorCuenta = gestorCuenta;
            this.gestorMovimientos = gestorMovimientos;
            this.gestorPlan = gestorPlan;
            this.gestorTipoMovmientos = gestorTipoMovmientos;
            this.dbHelper = dbhelper;

            //Buscar
            buscarClienteForm = new BuscarCliente(gestorCliente);
            buscarClienteForm.FormClosed += BuscarClienteForm_FormClosed;

            buscarPlanForm = new BuscarPlan(gestorPlan);


            pantallaPredeterminada();

        }


        
        private void CambiarFuente(Control control, Font nuevaFuente)
        {
            control.Font = nuevaFuente;

            foreach (Control hijo in control.Controls)
            {
                CambiarFuente(hijo, nuevaFuente);
            }
        }


        private void pantallaPredeterminada()
        {
            clienteSeleccionado = null;
            planSeleccionado = null;

            volverBtn.ForeColor = Color.White;
            volverBtn.BackColor = Color.Red;

            resumenCuentaBtn.Enabled = false;

            modificarClienteCb.Checked = false;
            clienteNuevoCb.Checked = false;
            registrarClienteBtn.Enabled = false;
            modificarBtn.Enabled = false;
            clienteSeleccionado = null;

            isUpdating = true;
            clienteNuevoCb.Checked = false;
            isUpdating = true;
            modificarClienteCb.Checked = false;

            comboBoxPlanes.DataSource = gestorPlan.getPlanList();
            comboBoxPlanes.DisplayMember = "nombre"; 


            ocultarModificacionCliente();
            limpiarCliente();
            limpiarPago();

            ocultarPagos();
            isUpdating = false;

            cambiarColorEstado();


        }
        private void limpiarPago()
        {
            efectivoTb.Text = "";
            transferenciaTb.Text = "";
            descuentoTb.Text = "";

        }

        private void habilitarPagos()
        {
            efectivoTb.ReadOnly = false;
            efectivoTb.BackColor = SystemColors.Window;

            transferenciaTb.ReadOnly = false;
            transferenciaTb.BackColor = SystemColors.Window;

            descuentoTb.ReadOnly = false;
            descuentoTb.BackColor = SystemColors.Window;

            registrarPagoBtn.Enabled = true;

        }
        private void habilitarModificacionCliente()
        {
            nombreTb.ReadOnly = false;
            nombreTb.BackColor = SystemColors.Window;

            telefonoTb.ReadOnly = false;
            telefonoTb.BackColor = SystemColors.Window;

            if (modificarClienteCb.Checked)
            {
                altaCb.Enabled = true;
                bajaCb.Enabled = true;
            }

            comboBoxPlanes.Enabled = true;
            comboBoxPlanes.BackColor = SystemColors.Window;
        }




        private void ocultarPagos()
        {

            efectivoTb.ReadOnly = true;
            efectivoTb.BackColor = Color.LightGray;

            transferenciaTb.ReadOnly = true;
            transferenciaTb.BackColor = Color.LightGray;

            descuentoTb.ReadOnly = true;
            descuentoTb.BackColor = Color.LightGray;

            registrarPagoBtn.Enabled = false;
        }

        private void  cambiarFont()
        {

            if (Screen.PrimaryScreen.Bounds.Width == 1920 && Screen.PrimaryScreen.Bounds.Height == 1080)
            {
                Font fuente = new Font("Microsoft Sans Serif", 24, FontStyle.Regular);
                altaCb.Font = fuente;
                bajaCb.Font = fuente;
                clienteNuevoCb.Font = fuente;
                modificarClienteCb.Font = fuente;
                cuotaTb.Font = fuente;
                nombreTb.Font = fuente;
                telefonoTb.Font = fuente;
                saldoTb.Font = fuente;
                cuotaTb.Font = fuente;
                efectivoTb.Font = fuente;
                transferenciaTb.Font = fuente;
                descuentoTb.Font = fuente;
                limpiarPantalla.Font = fuente;
                volverBtn.Font = fuente;
                registrarClienteBtn.Font = fuente;
                registrarPagoBtn.Font = fuente;
                modificarBtn.Font = fuente;
                resumenCuentaBtn.Font = fuente;

                nombreLb.Font = fuente;
                telefonoLb.Font = fuente;
                label4.Font = fuente;
                estadoLb.Font = fuente;
                planLb.Font = fuente;
                cuotaLb.Font = fuente;  
                efectivoLb.Font = fuente;
                transferenciaLb.Font = fuente;
                descuentoLb.Font = fuente;
                buscarClienteBtn.Font = fuente;
                comboBoxPlanes.Font = fuente;

                clientePanel.Font = fuente;
                pagoPanel.Font = fuente;
                planPanel.Font = fuente;
            }
            else
            {
                Font fuente = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
                altaCb.Font = fuente;
                bajaCb.Font = fuente;
                resumenCuentaBtn.Font= fuente;
                clienteNuevoCb.Font = fuente;
                modificarClienteCb.Font = fuente;
                cuotaTb.Font = fuente;
                nombreTb.Font = fuente;
                telefonoTb.Font = fuente;
                saldoTb.Font = fuente;
                descuentoTb.Font = fuente;

                cuotaTb.Font = fuente;
                efectivoTb.Font = fuente;
                transferenciaTb.Font = fuente;
                limpiarPantalla.Font = fuente;
                volverBtn.Font = fuente;
                registrarClienteBtn.Font = fuente;
                registrarPagoBtn.Font = fuente;
                modificarBtn.Font = fuente;
                nombreLb.Font = fuente;
                telefonoLb.Font = fuente;
                label4.Font = fuente;
                estadoLb.Font = fuente;
                planLb.Font = fuente;
                cuotaLb.Font = fuente;
                efectivoLb.Font = fuente;
                transferenciaLb.Font = fuente;
                descuentoLb.Font = fuente;
                buscarClienteBtn.Font = fuente;
                comboBoxPlanes.Font = fuente;
                clientePanel.Font = fuente;
                pagoPanel.Font = fuente;
                planPanel.Font = fuente;


            }
        }



        private void BuscarClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscarClienteForm.actualizarGridPublico();
            Cliente seleccion = buscarClienteForm.getClienteSeleccionado();
            if (seleccion == null)
            {
                return;
            }
            clienteSeleccionado = seleccion;


            if (!modificarClienteCb.Checked)
            {
                ocultarModificacionCliente();
                habilitarPagos();
                cargarCamposCliente();
                resumenCuentaBtn.Enabled = true;

            }
            else if (modificarClienteCb.Checked)
            {
                modificandoCliente = true;
                aparienciaModificar();
            }


        }






        private void registrarPagoBtn_Click(object sender, EventArgs e)
        {
            bool errores = false;
            bool pagoEnEfectivo = false;
            bool pagoEnTransferencia = false;
            bool descuento = false;
            float montoEfectivo = 0;
            float montoTransferencia = 0;

            //Cheque que el cliente este activo.
            if (!clienteSeleccionado.getEstado())
            {
                DialogResult result = MessageBox.Show("El cliente seleccionado esta inactivo ¿Seguro que desea registrar el pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Validación del monto en efectivo
            if (!string.IsNullOrWhiteSpace(efectivoTb.Text))
            {
                efectivoTb.Text = efectivoTb.Text.Trim();

                if (float.TryParse(efectivoTb.Text, out montoEfectivo))
                {
                    if (montoEfectivo <= 0)
                    {
                        MessageBox.Show("El monto en efectivo debe ser mayor a 0.");
                        errores = true;
                    }
                    else
                    {
                        pagoEnEfectivo = true;
                        MessageBox.Show("pagoEfectivo");

                    }
                }
                else
                {
                    MessageBox.Show("Monto en efectivo no válido. Ingrese un número válido.");
                    errores = true;
                }
            }
            //Validacion descuento
            // Descuento
            if (!string.IsNullOrWhiteSpace(this.descuentoTb.Text))// Entra en caso de que haya algo dento de descuentoTb
            {
                this.descuentoTb.Text = this.descuentoTb.Text.Trim();

                // Intentar convertir el texto a float
                if (float.TryParse(this.descuentoTb.Text, out _))
                {
                    importeDescuento = float.Parse(this.descuentoTb.Text);

                    if (importeDescuento == 0)
                    {
                        MessageBox.Show("Descuento no puede ser 0.");
                        errores = true;
                    }
                    MessageBox.Show("descuentoDetectado");
                    descuento = true;
                    //Una vez corroborado que el interior del descuento no está vacío y es válido para convertir a float, se crea el descuento.



                }
                else // En el caso de que lo ingresado no pueda ser pasado a float
                {
                    MessageBox.Show("Descuento no valido (Caracter invalido).");
                    errores = true;
                    ; // Retorna si el texto no se puede convertir a float                

                }
            }


            // Validación del monto en transferencia
            if (!string.IsNullOrWhiteSpace(transferenciaTb.Text))
            {
                transferenciaTb.Text = transferenciaTb.Text.Trim();
                if (float.TryParse(transferenciaTb.Text, out montoTransferencia))
                {
                    if (montoTransferencia <= 0)
                    {
                        MessageBox.Show("El monto de transferencia debe ser mayor a 0.");
                        errores = true;
                    }
                    else
                    {
                        pagoEnTransferencia = true;
                        MessageBox.Show("");

                    }
                }
                else
                {
                    MessageBox.Show("Monto de transferencia no válido. Ingrese un número válido.");
                    errores = true;
                }
            }

            // Verificar que al menos un método de pago tenga un valor
            if (!pagoEnEfectivo && !pagoEnTransferencia)
            {
                MessageBox.Show("Debe ingresar al menos un método de pago (efectivo o transferencia).");
                errores = true;
            }




            if (!errores)  //En caso de q no haya ningun error
            {
                MessageBox.Show("entro");
                TipoMovmiento tipoMovimientoPago = gestorTipoMovmientos.validarExistenciaTipoMov("Pago Cuota", true);
                bool pagosRealizados = false;

                // Registrar pago en efectivo si corresponde
                if (pagoEnEfectivo)
                {
                    Pago pagoEfectivo = new Pago(clienteSeleccionado.getCuenta(),
                                                dbHelper.GetLastId("movimientos", "idmovimientos"),
                                                montoEfectivo,
                                                tipoMovimientoPago,
                                                1); // 1 = efectivo

                    gestorMovimientos.addMovmiento(pagoEfectivo);
                    dbHelper.insertarMovmiento(pagoEfectivo);
                    pagosRealizados = true;
                }

                // Registrar pago por transferencia si corresponde
                if (pagoEnTransferencia)
                {
                    Pago pagoTransferencia = new Pago(clienteSeleccionado.getCuenta(),
                                                    dbHelper.GetLastId("movimientos", "idmovimientos"),
                                                    montoTransferencia,
                                                    tipoMovimientoPago,
                                                    2); // 2 = transferencia

                    gestorMovimientos.addMovmiento(pagoTransferencia);
                    dbHelper.insertarMovmiento(pagoTransferencia);
                    pagosRealizados = true;
                }

                if (descuento)//Registra descuento si corresponde
                {
                    TipoMovmiento tipoMovimientoDescuento = gestorTipoMovmientos.validarExistenciaTipoMov("Descuento", true);

                    int idDescuento = dbHelper.GetLastId("movimientos", "idmovimientos");

                    movimientoDescuento = new Movimiento(clienteSeleccionado.getCuenta(), idDescuento, importeDescuento, tipoMovimientoDescuento);

                    gestorMovimientos.addMovmiento(movimientoDescuento);
                    dbHelper.insertarMovmiento(movimientoDescuento);


                    limpiarPago();
                    pagosRealizados = true;
                }

                if (pagosRealizados) // Se acomodo el mensaje que se muestra en pantalla
                {
                    string mensajePago = "";

                    if (pagoEnEfectivo && pagoEnTransferencia)
                        mensajePago = "Pagos en efectivo y transferencia registrados.";
                    else if (pagoEnEfectivo)
                        mensajePago = "Pago en efectivo registrado.";
                    else if (pagoEnTransferencia)
                        mensajePago = "Pago por transferencia registrado.";

                    if (descuento)
                    {
                        mensajePago += "\nDescuento registrado. ";
                    }
                    MessageBox.Show(mensajePago);
                    limpiarPago();
                }
                cargarCamposCliente();
            }
        }


        private void cambiarColorEstado()
        {
            if (altaCb.Checked == true)
            {
                altaCb.BackColor = Color.LightGreen;
                bajaCb.BackColor = SystemColors.ControlLight;

            }
            else if (bajaCb.Checked)
            {
                bajaCb.BackColor = Color.Red;
                altaCb.BackColor = SystemColors.ControlLight;
            }
            else
            {
                bajaCb.BackColor = SystemColors.ControlLight;
                altaCb.BackColor = SystemColors.ControlLight;

            }
        }
        public void cargarCamposCliente()
        {
            comboBoxPlanes.DataSource = gestorPlan.getPlanList();
            if (clienteSeleccionado != null)
            {
                nombreTb.Text = clienteSeleccionado.getNombre();
                telefonoTb.Text = clienteSeleccionado.getTelefono();
                saldoTb.Text = $"{clienteSeleccionado.getCuenta().getSaldo()}";
    

                comboBoxPlanes.SelectedItem = clienteSeleccionado.getPlanAsociado();
                comboBoxPlanes.Text = clienteSeleccionado.getPlanAsociado().getNombrePlan();
                

                cuotaTb.Text = $"{clienteSeleccionado.getPlanAsociado().getCuota()}";

                if (clienteSeleccionado.getEstado() == true)
                {
                    altaCb.Checked = true;
                    bajaCb.Checked = false;
                    cambiarColorEstado();
                }
                else
                {
                    altaCb.Checked = false;
                    bajaCb.Checked = true;
                    cambiarColorEstado();
                }


            }



        }

        private void ocultarModificacionCliente()
        {


            nombreTb.ReadOnly = true;
            nombreTb.BackColor = Color.LightGray;

            telefonoTb.ReadOnly = true;
            telefonoTb.BackColor = Color.LightGray;

            saldoTb.ReadOnly = true;
            saldoTb.BackColor = Color.LightGray;

            comboBoxPlanes.Enabled = false;
            comboBoxPlanes.BackColor = Color.Gray;

            cuotaTb.ReadOnly = true;
            cuotaTb.BackColor = Color.LightGray;

            altaCb.Enabled = false;
            bajaCb.Enabled = false;

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

     

        private void Cliente_Click(object sender, EventArgs e)
        {
            buscarClienteForm.ShowDialog();
        }



        

        private void efectivoCb_CheckedChanged(object sender, EventArgs e)
        {
            medioPago = 1;
        }

        private void tranferenciaCb_CheckedChanged(object sender, EventArgs e)
        {
            medioPago = 2;
        }

        private bool isNameValid(string texto)
        {
            // Verifica si el texto está vacío o es nulo
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Debe ingresar un nombre valido.");
                return false;
            }

            // Verificar si contiene algún dígito
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Debe ingresar un nombre valido.");

                    return false;
                }
            }

            return true;
        }


        private void movimientosCambioPlan(float oldCuota,float newCuota)
        {
            try
            {
                TipoMovmiento tipoCorrigeCambio = gestorTipoMovmientos.validarExistenciaTipoMov("Cambio de Plan", true);
                Movimiento movimentocamplan = new Movimiento(gestorCuenta.getCuenta(clienteSeleccionado.getId()), dbHelper.GetLastId("movimientos", "idmovimientos"), oldCuota, tipoCorrigeCambio);
                gestorMovimientos.addMovmiento(movimentocamplan);
                dbHelper.insertarMovmiento(movimentocamplan);
                //Nueva cuota:
                TipoMovmiento tipoGenCuota = gestorTipoMovmientos.validarExistenciaTipoMov("Generacion Cuota", false);
                Movimiento movimientoGenCuota = new Movimiento(gestorCuenta.getCuenta(clienteSeleccionado.getId()), dbHelper.GetLastId("movimientos", "idmovimientos"), newCuota, tipoGenCuota);
                gestorMovimientos.addMovmiento(movimientoGenCuota);
                dbHelper.insertarMovmiento(movimientoGenCuota);
            }
            catch (Exception e) 
            {
                MessageBox.Show($"Error al realizar cambio de plan: {e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void resumenCuentaBtn_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                // Obtener el fin del mes actual
                DateTime hastaFecha = DateTime.Today.AddDays(1).Date;
       
        

                // Obtener el primer día de 3 meses atrás
                DateTime desdeFecha = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                    .AddMonths(-3);


                //Se crean los recursos necesarios para el visor del repor  te.
                float saldoAnterior = clienteSeleccionado.getCuenta().getSaldoAnterior(desdeFecha);
                DataTable table = dbHelper.generateResumenCuentaDt(clienteSeleccionado.getCuenta().getIdCuenta(), desdeFecha, hastaFecha, saldoAnterior);
                string datosCliente = $"Nro: {clienteSeleccionado.getId()}   Nombre: {clienteSeleccionado.getNombre()}   Tel: {clienteSeleccionado.getTelefono()}";

                visorResumenCuentaForm visorResumenCuenta = new visorResumenCuentaForm(table, saldoAnterior, datosCliente);
                visorResumenCuenta.ShowDialog();

            }
        }

        private void limpiarCliente()
        {
            nombreTb.Text = "";
            telefonoTb.Text = "";
            saldoTb.Text = "";
            comboBoxPlanes.SelectedItem = null;
            cuotaTb.Text = "";
            altaCb.Checked = false;
            bajaCb.Checked = false;
            comboBoxPlanes.Text = null;
            cambiarColorCb();
        }



        private void generarCuotaPlan()
        {
            // Primero se valida la existencia o se crea el tipo de movimiento generar cuota.
            TipoMovmiento genCuotaTipoMov = gestorTipoMovmientos.validarExistenciaTipoMov("Generacion Cuota", false);
            //Luego se crea el movimiento
            Movimiento planCuotaMovimiento = new Movimiento(cuentaNueva, dbHelper.GetLastId("movimientos", "idmovimientos"), planSeleccionado.getCuota(), genCuotaTipoMov);
            //Se guarda en la base de datos y en el gestor
            gestorMovimientos.addMovmiento(planCuotaMovimiento);
            dbHelper.insertarMovmiento(planCuotaMovimiento);
        }

        private void registrarClienteBtn_Click(object sender, EventArgs e)
        {


            clienteNuevo = null;

            int idNuevoCliente = dbHelper.GetLastId("clientes", "id");

            bool error = false;
            // Se toman los string ingresados en los textbox

            //gestorCliente.getNuevoID
            //Persona
            string nombreIngresado = nombreTb.Text.Trim();

            if (string.IsNullOrEmpty(nombreIngresado))
            {

                MessageBox.Show("Ingresa un nombre valido.");
                error = true;

            }

            //Telefono y verificacion

            string telefonoIngresado = telefonoTb.Text.Trim();

            if (string.IsNullOrEmpty(telefonoIngresado))
            {
                MessageBox.Show("Ingrese un numero de telefono.");
                error = true;
            }
            else if (!IsValidPhoneNumber(telefonoIngresado))
            {
                MessageBox.Show("Número de teléfono inválido. Debe respetar el siguiente formato; código de area (2-4 cifras) + número (7 cifras)", "Error", MessageBoxButtons.OK);
                error = true;
            }


            //Verificar la seleccion del plan
            if (planSeleccionado == null)
            {
                error = true;
                MessageBox.Show("Seleccione un plan");
            }

            //Verificar coincidencias de nombre
            string nombreRepetido = gestorCliente.ClienteYaExiste(nombreIngresado);
            if (nombreRepetido != null)
            {
                DialogResult resultado = MessageBox.Show(
                $"Se encontro un cliente existente con el nombre {nombreRepetido}. ¿Desea registrar a {nombreIngresado} de todas formas?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
                );

                if (resultado != DialogResult.OK)
                {
                    error = true;
                }


            }

            if (error != true)
            {

                // Cuenta
                cuentaNueva = new Cuenta(idNuevoCliente);

                Cliente clienteNuevo = new Cliente(idNuevoCliente, nombreIngresado, telefonoIngresado,
                                        planSeleccionado, cuentaNueva, true, DateTime.Now);

                //se guarda en la bd sql
                dbHelper.InsertarCuenta(cuentaNueva);
                dbHelper.InsertarCliente(clienteNuevo);

                //se guarda localmente

                gestorCuenta.addCuenta(cuentaNueva);
                gestorCliente.cargarCliente(clienteNuevo);

                MessageBox.Show("Cliente registrado.");
               
                //Se genera la cuota correspondiente al plan. En caso de que ya se haya generado la cuota general
                if (dbHelper.ExisteGenCuotaDelMesActual())
                {
                    generarCuotaPlan();
                }
                else
                {
                    MessageBox.Show("Aún no se han generado las cuotas correspondientes al mes actual, por lo que no se puede asignar una cuota al cliente en este momento.", "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

                //Se sierra el el form.


                //Finalmente se restaura la pantalla
                clienteSeleccionado = clienteNuevo; // Se selecciona el nuevo cliente y se vacia el cliente nuevo.
                clienteNuevo = null;
                clienteNuevoEnProceso = false;

                isUpdating = true;
                clienteNuevoCb.Checked = false;

                aparienciaNuevoCliente();
                cambiarColorCb();
                buscarClienteForm.actualizarGridPublico();

                isUpdating = false;
            }

        }


        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Eliminar espacios, guiones, paréntesis y otros caracteres no numéricos
            string numeroLimpio = new string(phoneNumber.Where(char.IsDigit).ToArray());



            // La longitud total debe ser entre 9 y 11 dígitos
            // (2 a 4 dígitos para código de área + 7 dígitos para el número)
            if (numeroLimpio.Length < 9 || numeroLimpio.Length > 11)
            {
                return false;
            }

            // Separar código de área y número
            string codigoArea = numeroLimpio.Substring(0, numeroLimpio.Length - 7);
            string numeroLocal = numeroLimpio.Substring(numeroLimpio.Length - 7);

            // Validar longitud del código de área (2 a 4 dígitos)
            if (codigoArea.Length < 2 || codigoArea.Length > 4)
            {
                return false;
            }

            // Validar que el número local tenga exactamente 7 dígitos
            if (numeroLocal.Length != 7)
            {
                return false;
            }

            return true;
        }




        private void aparienciaModificar()
        {
            if (modificarClienteCb.Checked && clienteNuevoCb.Checked) //Caso donde se interviene el registro de un nuevo cliente.
            {
                isUpdating = true;
                modificarClienteCb.Checked = false;
                DialogResult result = MessageBox.Show("Registro de nuevo cliente en curso ¿Desea descartarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isUpdating = true;
                    modificarClienteCb.Checked = true;
                    isUpdating = true;
                    clienteNuevoCb.Checked = false;

                    limpiarCliente();
                    limpiarPago();
                    ocultarModificacionCliente();
                    ocultarPagos();
                    comboBoxPlanes.Enabled = false;
                    buscarClienteBtn.Enabled = true;
                    resumenCuentaBtn.Enabled = false;
                    registrarClienteBtn.Enabled = false;
                }
            }
            else if (modificarClienteCb.Checked && clienteSeleccionado != null)  //Caso donde se presiona modificar con cliente seleccionado
            {
                habilitarModificacionCliente();
                cargarCamposCliente();
                ocultarPagos();
                limpiarPago();
                modificandoCliente = true;
                resumenCuentaBtn.Enabled = false;
                registrarClienteBtn.Enabled = false;
                modificarBtn.Enabled = true;
                comboBoxPlanes.Enabled = true;


            }
            else if (!modificarClienteCb.Checked && modificandoCliente) // Caso donde se cancela la modificacion
            {
                DialogResult result = MessageBox.Show("Modificaion en curso ¿Desea cancelarla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ocultarModificacionCliente();
                    cargarCamposCliente();
                    habilitarPagos();
                    
                    resumenCuentaBtn.Enabled = true;
                    registrarClienteBtn.Enabled = false;
                    modificarBtn.Enabled = false;
                    comboBoxPlanes.Enabled = false;
                    registrarPagoBtn.Enabled = true;

                }


            }
            else if (!modificarClienteCb.Checked && !modificandoCliente && clienteSeleccionado != null) // Caso donde se registro la modificacion
            {
                habilitarPagos();
                cargarCamposCliente();
                ocultarModificacionCliente();
                registrarPagoBtn.Enabled = true;
                comboBoxPlanes.Enabled = false;
                comboBoxPlanes.BackColor = Color.Gray;
                registrarClienteBtn.Enabled = false;
                modificarBtn.Enabled = false;
                resumenCuentaBtn.Enabled = true;
                isUpdating = false;
            }


        }


        private void aparienciaNuevoCliente()
        {

            if (modificarClienteCb.Checked) // En caso de que se este modificando un cliente primero se informa si desea desechar los cambios.
            {
                isUpdating = true;
                modificarClienteCb.Checked = false;
                isUpdating = false;


                if (clienteSeleccionado != null)
                {
                    DialogResult result = MessageBox.Show("Modificacion en curso ¿Desea descartar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        isUpdating = true;

                        modificarClienteCb.Checked = true;
                        isUpdating = true;
                        clienteNuevoCb.Checked = false;

                        return;
                    }
                    else
                    {
                        //Desmarcar el modificar.
                        isUpdating = true;
                        modificarClienteCb.Checked = false;
                        //Habilitar pantalla para nuevo cliente
                        clienteNuevoEnProceso = true;
                        limpiarPago();
                        ocultarPagos();
                        limpiarCliente();
                        habilitarModificacionCliente();
                        clienteSeleccionado = null;
                        buscarClienteBtn.Enabled = false;
                        comboBoxPlanes.Enabled = true;
                        registrarClienteBtn.Enabled = true;
                        resumenCuentaBtn.Enabled = false;
                        modificarBtn.Enabled = false;
                        bajaCb.Enabled = false;
                        altaCb.Enabled = false;
                    }
                }
                else
                {
                    //Desmarcar el modificar.
                    isUpdating = true;
                    modificarClienteCb.Checked = false;
                    isUpdating = false;

                    //Habilitar pantalla para nuevo cliente
                    clienteNuevoEnProceso = true;
                    limpiarPago();
                    ocultarPagos();
                    limpiarCliente();
                    habilitarModificacionCliente();
                    clienteSeleccionado = null;
                    buscarClienteBtn.Enabled = false;
                    comboBoxPlanes.Enabled = true;
                    registrarClienteBtn.Enabled = true;
                    resumenCuentaBtn.Enabled = false;
                    modificarBtn.Enabled = false;
                    bajaCb.Enabled = false;
                    altaCb.Enabled = false;
                }

            }

            else if (!clienteNuevoCb.Checked && clienteNuevoEnProceso) //Se consulta si se desea cancelar el nuevo cliente
            {

                DialogResult result = MessageBox.Show("Registro de nuevo cliente en curso ¿Desea descartarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    limpiarCliente();
                    limpiarPago();
                    ocultarModificacionCliente();
                    ocultarPagos();
                    comboBoxPlanes.Enabled = false;
                    buscarClienteBtn.Enabled = true;
                    resumenCuentaBtn.Enabled = false;
                    registrarClienteBtn.Enabled = false;
                    modificarBtn.Enabled = false;
                }
                else
                {
                    //Se acomoda el check
                    isUpdating = true;
                    clienteNuevoCb.Checked = true;
                }

            }
            else if (!clienteNuevoCb.Checked && !clienteNuevoEnProceso) // Caso donde se cargo el cliente

            {

                cargarCamposCliente();
                ocultarModificacionCliente();
                habilitarPagos();
                modificarBtn.Enabled = false;
                comboBoxPlanes.Enabled = false;
                registrarClienteBtn.Enabled = false;
                buscarClienteBtn.Enabled = true;
                resumenCuentaBtn.Enabled = true;

            }

            else if (clienteNuevoCb.Checked) // Si todo es normal se procede a habilitar la pantalla para registrar un cliente.
            {
                limpiarPago();
                ocultarPagos();
                limpiarCliente();
                habilitarModificacionCliente();
                clienteNuevoEnProceso = true;

                clienteSeleccionado = null;
                buscarClienteBtn.Enabled = false;
                comboBoxPlanes.Enabled = true;
                registrarClienteBtn.Enabled = true;
                resumenCuentaBtn.Enabled = false;
                modificarBtn.Enabled = false;
                bajaCb.Enabled = false;
                altaCb.Enabled = false;

            }
        }
        private void cambiarColorCb()
        {
            if (clienteNuevoCb.Checked)
            {
                clienteNuevoCb.ForeColor = Color.Blue;
                modificarClienteCb.ForeColor = SystemColors.ControlText;
            }
            else if (modificarClienteCb.Checked)
            {
                modificarClienteCb.ForeColor = Color.Blue;
                clienteNuevoCb.ForeColor = SystemColors.ControlText;
            }
            else
            {
                clienteNuevoCb.ForeColor= SystemColors.ControlText;
                modificarClienteCb.ForeColor = SystemColors.ControlText;
            }

        }
        private void clienteNuevoCb_CheckedChanged(object sender, EventArgs e)
        {

            if (isUpdating) return; // Evitar recursividad

            aparienciaNuevoCliente();
            cambiarColorCb();
            isUpdating = false;

        }

        private void modificarClienteCb_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            aparienciaModificar();
            cambiarColorCb();
            isUpdating = false;
        }

        private void bajaCb_CheckedChanged(object sender, EventArgs e)
        {
            cambiarColorEstado();
        }

        private void altaCb_CheckedChanged(object sender, EventArgs e)
        {
            cambiarColorEstado();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
            isUpdating = true;
            pantallaPredeterminada();

            PantallaInicial mainForm = this.ParentForm as PantallaInicial;
            if (mainForm != null)
            {
                mainForm.menuStrip1.Visible = true; // Ejemplo de acceso
            }
        }

        private void limpiarPantalla_Click(object sender, EventArgs e)
        {
            pantallaPredeterminada();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registrarPagoBtn_Click_1(object sender, EventArgs e)
        {
        
            bool errores = false;
            bool pagoEnEfectivo = false;
            bool pagoEnTransferencia = false;
            bool descuento = false;
            float montoEfectivo = 0;
            float montoTransferencia = 0;



            // Validación del monto en efectivo
            if (!string.IsNullOrWhiteSpace(efectivoTb.Text))
            {
                efectivoTb.Text = efectivoTb.Text.Trim();

                if (float.TryParse(efectivoTb.Text, out montoEfectivo))
                {
                    if (montoEfectivo <= 0)
                    {
                        MessageBox.Show("El monto en efectivo debe ser mayor a 0.");
                        errores = true;
                    }
                    else
                    {
                        pagoEnEfectivo = true;

                    }
                }
                else
                {
                    MessageBox.Show("Monto en efectivo no válido. Ingrese un número válido.");
                    errores = true;
                }
            }
            //Validacion descuento
            // Descuento
            if (!string.IsNullOrWhiteSpace(this.descuentoTb.Text))// Entra en caso de que haya algo dento de descuentoTb
            {
                this.descuentoTb.Text = this.descuentoTb.Text.Trim();

                // Intentar convertir el texto a float
                if (float.TryParse(this.descuentoTb.Text, out _))
                {
                    importeDescuento = float.Parse(this.descuentoTb.Text);

                    if (importeDescuento == 0)
                    {
                        MessageBox.Show("Descuento no puede ser 0.");
                        errores = true;
                    }
                    descuento = true;
                    //Una vez corroborado que el interior del descuento no está vacío y es válido para convertir a float, se crea el descuento.



                }
                else // En el caso de que lo ingresado no pueda ser pasado a float
                {
                    MessageBox.Show("Descuento no valido (Caracter invalido).");
                    errores = true;
                    ; // Retorna si el texto no se puede convertir a float                

                }
            }


            // Validación del monto en transferencia
            if (!string.IsNullOrWhiteSpace(transferenciaTb.Text))
            {
                transferenciaTb.Text = transferenciaTb.Text.Trim();
                if (float.TryParse(transferenciaTb.Text, out montoTransferencia))
                {
                    if (montoTransferencia <= 0)
                    {
                        MessageBox.Show("El monto de transferencia debe ser mayor a 0.");
                        errores = true;
                    }
                    else
                    {
                        pagoEnTransferencia = true;

                    }
                }
                else
                {
                    MessageBox.Show("Monto de transferencia no válido. Ingrese un número válido.");
                    errores = true;
                }
            }


            // Verificar que al menos un método de pago tenga un valor
            if (!pagoEnEfectivo && !pagoEnTransferencia && string.IsNullOrWhiteSpace(this.descuentoTb.Text))
            {
                MessageBox.Show("No se ha detectado ningun importe.");
                errores = true;
            }

            //Cheque que el cliente este activo.
            if (!clienteSeleccionado.getEstado())
            {
                DialogResult result = MessageBox.Show("El cliente seleccionado esta inactivo ¿Seguro que desea registrar el pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    limpiarPago();
                    return;
                }
            }
            if (clienteSeleccionado.getCuenta().getSaldo() > 0 && !errores)
            {
                DialogResult result = MessageBox.Show("Actualmente el saldo del cliente es positivo. ¿Seguro que desea registrar el pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    limpiarPago();
                    return;
                }
            }




            if (!errores)  //En caso de q no haya ningun error
            {
                TipoMovmiento tipoMovimientoPago = gestorTipoMovmientos.validarExistenciaTipoMov("Pago Cuota", true);
                bool pagosRealizados = false;

                // Registrar pago en efectivo si corresponde
                if (pagoEnEfectivo)
                {
                    Pago pagoEfectivo = new Pago(clienteSeleccionado.getCuenta(),
                                                dbHelper.GetLastId("movimientos", "idmovimientos"),
                                                montoEfectivo,
                                                tipoMovimientoPago,
                                                1); // 1 = efectivo

                    gestorMovimientos.addMovmiento(pagoEfectivo);
                    dbHelper.insertarMovmiento(pagoEfectivo);

                    pagosRealizados = true;
                }

                // Registrar pago por transferencia si corresponde
                if (pagoEnTransferencia)
                {
                    Pago pagoTransferencia = new Pago(clienteSeleccionado.getCuenta(),
                                                    dbHelper.GetLastId("movimientos", "idmovimientos"),
                                                    montoTransferencia,
                                                    tipoMovimientoPago,
                                                    2); // 2 = transferencia

                    gestorMovimientos.addMovmiento(pagoTransferencia);
                    dbHelper.insertarMovmiento(pagoTransferencia);
                    pagosRealizados = true;
                }

                if (descuento)//Registra descuento si corresponde
                {
                    TipoMovmiento tipoMovimientoDescuento = gestorTipoMovmientos.validarExistenciaTipoMov("Descuento", true);

                    int idDescuento = dbHelper.GetLastId("movimientos", "idmovimientos");

                    movimientoDescuento = new Movimiento(clienteSeleccionado.getCuenta(), idDescuento, importeDescuento, tipoMovimientoDescuento);

                    gestorMovimientos.addMovmiento(movimientoDescuento);
                    dbHelper.insertarMovmiento(movimientoDescuento);


                    limpiarPago();
                    pagosRealizados = true;
                }

                if (pagosRealizados) // Se acomodo el mensaje que se muestra en pantalla
                {
                    string mensajePago = "";

                    if (pagoEnEfectivo && pagoEnTransferencia)
                        mensajePago = "Pagos en efectivo y transferencia registrados.";
                    else if (pagoEnEfectivo)
                        mensajePago = "Pago en efectivo registrado.";
                    else if (pagoEnTransferencia)
                        mensajePago = "Pago por transferencia registrado.";

                    if (descuento)
                    {
                        mensajePago += "\nDescuento registrado. ";
                    }
                    MessageBox.Show(mensajePago, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCamposCliente();
                    limpiarPago();
                    //Actualizar pantalla de clientes
                    buscarClienteForm.actualizarGridPublico();
                }
            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private bool concurrenciaPlanes = false;
        private void comboBoxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (concurrenciaPlanes == true)
            {
                concurrenciaPlanes = false;
                return;
            }
            if (comboBoxPlanes.SelectedItem == null)
            {
                return;
            }         

            Plan seleccionado = gestorPlan.getPlan(comboBoxPlanes.SelectedIndex + 1) as Plan;   

            
            if (seleccionado.getEstado() == false)
            {
                MessageBox.Show("Plan no es seleccionable, ya que se encuentra inhabilitado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxPlanes.SelectedItem = null;
                return;
            }
            else
            {
                cuotaTb.Text =$"{seleccionado.getCuota()}";
                planSeleccionado = seleccionado;

            }

        }

        private void modificarBtn_Click_1(object sender, EventArgs e)
        {
            // Limpiamos los espacios en blanco de los campos de texto
            string nombreLimpio = nombreTb.Text?.Trim() ?? string.Empty;
            if (!isNameValid(nombreLimpio))
            {
                return;
            }

            string telefonoLimpio = telefonoTb.Text?.Trim() ?? string.Empty;
            if (telefonoLimpio != "")
            {
                if (!IsValidPhoneNumber(telefonoLimpio))
                {
                    MessageBox.Show("Número de teléfono inválido. Debe respetar el siguiente formato; código de area (2-4 cifras) + número (7 cifras)", "Error", MessageBoxButtons.OK);
                    return;
                }
            }



            string modificacionesStr = "Se realizarán las siguientes modificaciones: \n";
            bool hayModificaciones = false;

            // Verificamos las modificaciones sin aplicarlas
            if (!(clienteSeleccionado.getNombre().Equals(nombreLimpio)))
            {
                modificacionesStr += $"\nNombre: {clienteSeleccionado.getNombre()} --> {nombreLimpio}";
                hayModificaciones = true;
            }

            if (!(clienteSeleccionado.getTelefono().Equals(telefonoLimpio)))
            {
                modificacionesStr += $"\nTeléfono: {clienteSeleccionado.getTelefono()} --> {telefonoLimpio}";
                hayModificaciones = true;
            }

            if (planSeleccionado != null && !clienteSeleccionado.getPlanAsociado().Equals(planSeleccionado))
            {
                modificacionesStr += $"\nPlan: {clienteSeleccionado.getPlanAsociado().getNombrePlan()} --> {planSeleccionado.getNombrePlan()}";
                hayModificaciones = true;
            }

            if (!(clienteSeleccionado.getEstado().Equals(altaCb.Checked)))
            {
                modificacionesStr += $"\nEstado: {(clienteSeleccionado.getEstado() ? "Activo" : "Inactivo")} --> {(altaCb.Checked ? "Activo" : "Inactivo")}";
                hayModificaciones = true;
            }

            // Si no hay modificaciones, mostramos mensaje y salimos
            if (!hayModificaciones)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostramos los cambios y pedimos confirmación
            DialogResult resultado = MessageBox.Show(modificacionesStr,
                                                    "Confirmar Modificaciones",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question);

            // Solo aplicamos los cambios si el usuario confirma
            if (resultado == DialogResult.OK)
            {
                if (!(clienteSeleccionado.getNombre().Equals(nombreLimpio)))
                {
                    clienteSeleccionado.setNombre(nombreLimpio);
                }

                if (!(clienteSeleccionado.getTelefono().Equals(telefonoLimpio)))
                {
                    clienteSeleccionado.setTelefono(telefonoLimpio);
                }


                if (!(clienteSeleccionado.getEstado().Equals(altaCb.Checked)))
                {
                    clienteSeleccionado.setEstado(altaCb.Checked);
                    //Al dar de alta se corrobora si se genero la cuota del mes presente. Si asi es, se procede a generar la cuota correspondiente al plan.
                    if (dbHelper.ExisteGenCuotaDelMesActual())
                    {
                        // Primero se valida la existencia o se crea el tipo de movimiento generar cuota.
                        TipoMovmiento genCuotaTipoMov = gestorTipoMovmientos.validarExistenciaTipoMov("Generacion Cuota", false);
                        //Luego se crea el movimiento
                        Movimiento planCuotaMovimiento = new Movimiento(clienteSeleccionado.getCuenta(), dbHelper.GetLastId("movimientos", "idmovimientos"), clienteSeleccionado.getPlanAsociado().getCuota(), genCuotaTipoMov);
                        //Se guarda en la base de datos y en el gestor
                        gestorMovimientos.addMovmiento(planCuotaMovimiento);
                        dbHelper.insertarMovmiento(planCuotaMovimiento);
                    }
                }



                if (planSeleccionado != null && !clienteSeleccionado.getPlanAsociado().Equals(planSeleccionado))
                {
                    if (dbHelper.ExisteGenCuotaDelMesActual())
                    {
                        float oldCuota = clienteSeleccionado.getPlanAsociado().getCuota();
                        float newCuota = planSeleccionado.getCuota();
                        movimientosCambioPlan(oldCuota, newCuota);
                        clienteSeleccionado.setPlan(planSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Aun no se han generado las cuotas del mes presente, por lo que no es necesaria la correcion relacionada al plan.",
                            "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
);
                    }
                }
              



                // Finalmente se cierra el formulario y se guardad los cambios en la Db y se muestra el mensaje de que todo esta ok.

                dbHelper.modificarCliente(clienteSeleccionado);

                MessageBox.Show("Los cambios se aplicaron correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Se vuelve a la pantalla base.
                isUpdating = true;
                modificarClienteCb.Checked = false;
                modificandoCliente = false;
                buscarClienteForm.actualizarGridPublico();
                aparienciaModificar();
                cambiarColorCb();
                //Actualizar buscar cliente
                buscarClienteForm.actualizarGridPublico();


            }
            else
            {
                MessageBox.Show("Se cancelaron los cambios", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void actualizarGrid()
        {
            buscarClienteForm.actualizarGridPublico();
        }
    }


}