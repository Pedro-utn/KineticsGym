using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.Informes;
using PrototipoGym.Pantallas.Planes;
using PrototipoGym.Reportes;

namespace PrototipoGym.Pantallas
{
    public partial class Clientes : Form
    {
        gestorCliente clienteGestor;
        gestorCuenta cuenstasGestor;
        gestorMovimientos movimientosGestor;
        gestorPlan planesGestor;
        DatabaseHelper dbHelper;
        RegistrarClienteForm registrarClienteForm;
        BuscarCliente buscarClienteForm;
        Cliente clienteSeleccionado;
        gestorTipoMovmientos gestorTipoMov;



        public Clientes(gestorCliente clientes, gestorCuenta gestorCuenta, gestorMovimientos movimientos, gestorPlan planGestor,DatabaseHelper dbHelper, gestorTipoMovmientos gestorTipoMov)
        {
            InitializeComponent();

  

            clienteGestor = clientes;
            this.cuenstasGestor = gestorCuenta;
            this.movimientosGestor = movimientos;
            this.planesGestor = planGestor;
            this.dbHelper = dbHelper;
            this.gestorTipoMov = gestorTipoMov;
            buscarClienteForm = new BuscarCliente(clientes);
            MostrarFormularioEnPanel(buscarClienteForm);
        }
        private void MostrarFormularioEnPanel(Form form)
        {
            buscarClientePanel.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel

            buscarClientePanel.Controls.Add(form);
            buscarClienteForm.ocultarBotones();
            form.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;

            PantallaInicial mainForm = this.ParentForm as PantallaInicial;
            if (mainForm != null)
            {
                mainForm.menuStrip1.Visible = true; // Ejemplo de acceso
            }
        }



        private void nuevoClienteBtn_Click(object sender, EventArgs e)
        {
            registrarClienteForm = new RegistrarClienteForm(clienteGestor,planesGestor,cuenstasGestor,movimientosGestor,dbHelper,gestorTipoMov);
            registrarClienteForm.FormClosed += ActualizarGrid_FormClosed;
            //Se eliminan los botenes predeterminados de (minimizar/ampliar/cerrar)
            registrarClienteForm.ShowDialog();
        }

        private void mostrarCuentaBtn_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = buscarClienteForm.seleccinoarCliente();
            
            float saldoAnterior = clienteSeleccionado.getCuenta().getSaldoAnterior(DateTime.Now.AddDays(-30)); // se muestra la cuenta en los ultimos 30 dias.

            DataTable cuentaClienteTable = dbHelper.generateResumenCuentaDt(clienteSeleccionado.getCuenta().getIdCuenta(), DateTime.Now.AddDays(-30),DateTime.Now, saldoAnterior);


            string datosCliente = $"Nro: {clienteSeleccionado.getId()}   Nombre: {clienteSeleccionado.getNombre()}   Tel: {clienteSeleccionado.getTelefono()}";
            
            
            visorResumenCuentaForm cuentaClienteVisor = new visorResumenCuentaForm(cuentaClienteTable, saldoAnterior, datosCliente);
            cuentaClienteVisor.ShowDialog();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarClienteForm = new ModificarCliente(buscarClienteForm.seleccinoarCliente(),planesGestor,dbHelper);
            modificarClienteForm.FormClosed += ActualizarGrid_FormClosed;

            //Se eliminan los botenes predeterminados de (minimizar/ampliar/cerrar)

            modificarClienteForm.ShowDialog();
        }

        private void ActualizarGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            actualizarGrid();
        }
        public void actualizarGrid() 
        {
            //Se simula actualizar el dataGrid.
            buscarClienteForm.buscarClienteTb_TextChanged("", EventArgs.Empty);
        }

        private void generarCuotaBtn_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clienteGestor.getClienteList())  
            {
                if (cliente.getEstado() == true )
                {
                    Cuenta cuenta = cliente.getCuenta();
                    float importe = cliente.getPlanAsociado().getCuota();

                    TipoMovmiento cuotaTipoMov = gestorTipoMov.validarExistenciaTipoMov("Generacion cuota", false);

                    Movimiento generacionCuota = new Movimiento(cuenta,dbHelper.GetLastId("movimientos", "idmovimientos"),importe,cuotaTipoMov);

                    //Se guarda en local y sql

                    movimientosGestor.addMovmiento(generacionCuota);
                    dbHelper.insertarMovmiento(generacionCuota);



                }
            }
                    MessageBox.Show("Cuotas Generadas");
                    actualizarGrid();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
