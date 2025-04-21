using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;

namespace PrototipoGym.Pantallas
{
    
    public partial class RegistrarClienteForm : Form
    {

        private gestorCliente clientes;
        private gestorPlan planes;
        private gestorCuenta cuentas;
        private gestorMovimientos movimientos;
        private gestorTipoMovmientos gestorTipoMov;
        private Plan planSeleccionado;
        private DatabaseHelper dbHelper;
        private Cuenta cuentaNueva;
        private int idNuevoCliente;
        public RegistrarClienteForm(gestorCliente clientesSQL, gestorPlan planesSQL, gestorCuenta cuentasSQL, gestorMovimientos movimientosSQL,DatabaseHelper baseSQl,gestorTipoMovmientos gestorTipoMov)
        {
            InitializeComponent();
            this.clientes = clientesSQL;
            this.planes = planesSQL;
            this.cuentas = cuentasSQL;
            this.movimientos = movimientosSQL;
            this.dbHelper = baseSQl;
            this.gestorTipoMov = gestorTipoMov;
            this.ControlBox = false;

            setId();


        }

        private void setId() { //Metodo para obtener el id correspondiente y ponerlo en pantalla 
            idNuevoCliente = dbHelper.GetLastId("clientes","id");
            idLb.Text = $"Nro cliente: {idNuevoCliente}";
        }


        private void RegistrarNuevoClienteBtn_Click(object sender, EventArgs e)
        {
            bool error = false;
            // Se toman los string ingresados en los textbox

            //gestorCliente.getNuevoID
            //Persona
            string nombreIngresado = nombreTb.Text.Trim();

            if (string.IsNullOrEmpty(nombreIngresado) ) {

                MessageBox.Show("El campo está vacío. Por favor, ingresa un valor.");    
                error = true;

            }

            //Telefono y verificacion

            string telefonoIngresado = telefonoTb.Text.Trim();

            if (string.IsNullOrEmpty(telefonoIngresado)) {
                MessageBox.Show("Ingrese un numero de telefono!");
                error = true;
            }

            //Verificar la seleccion del plan
            if (planSeleccionado == null) 
            { 
                error = true;
                MessageBox.Show("Seleccione un plan");
            }

            if (error != true) 
            {
                // Cuenta
                cuentaNueva = new Cuenta(idNuevoCliente);

                Cliente clienteRegistrado = new Cliente(idNuevoCliente, nombreIngresado, telefonoIngresado,
                                        planSeleccionado, cuentaNueva, true, DateTime.Now);
                //se guarda localmente

                cuentas.addCuenta(cuentaNueva);
                clientes.cargarCliente(clienteRegistrado);

                //se guarda en la bd sql
                dbHelper.InsertarCuenta(cuentaNueva);
                dbHelper.InsertarCliente(clienteRegistrado);

                //Se genera la cuota correspondiente al plan.
                generarCuotaPlan();

                //Se sierra el el form.
                MessageBox.Show("Cliente registrado.");
                this.Close();

            }
            //Crear una cuenta



        }
        private void generarCuotaPlan() 
        {
            // Primero se valida la existencia o se crea el tipo de movimiento generar cuota.
            TipoMovmiento genCuotaTipoMov = gestorTipoMov.validarExistenciaTipoMov("Generacion cuota", false);
            //Luego se crea el movimiento
            Movimiento planCuotaMovimiento = new Movimiento(cuentaNueva,dbHelper.GetLastId("movimientos","idmovimientos"),planSeleccionado.getCuota(),genCuotaTipoMov);
            //Se guarda en la base de datos y en el gestor
            movimientos.addMovmiento(planCuotaMovimiento);
            dbHelper.insertarMovmiento(planCuotaMovimiento);
        }

        private void buscarPlanBtn_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            BuscarPlan buscadorPlan = new BuscarPlan(planes);
            //Suscripcion a evento de cierre
            buscadorPlan.FormClosed += BuscarPlan_FormClosed;

            // Mostrar el formulario secundario
            buscadorPlan.Show();

        }
        private void BuscarPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            var buscarPlanForm = sender as BuscarPlan;

            if (buscarPlanForm.getPlanSeleccionado() != null)
            {
                planSeleccionado = buscarPlanForm.getPlanSeleccionado();
                MessageBox.Show($"Formulario cerrado. Plan seleccionado: {planSeleccionado.getNombrePlan()}");
                planTb.Text = planSeleccionado.getNombrePlan();
            }
            else
            {
                MessageBox.Show("Formulario cerrado sin selección.");
            }
        }

        private void RegistrarClienteForm_Load(object sender, EventArgs e)
        {


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            PantallaInicial pantallaInicial = (PantallaInicial)this.ParentForm;
            
            this.Close(); // Cierra la ventana actual
        }

        private void nombreLb_Click(object sender, EventArgs e)
        {

        }

        private void idLb_Click(object sender, EventArgs e)
        {

        }
    }
}
