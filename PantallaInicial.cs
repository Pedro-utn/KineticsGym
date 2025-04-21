using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KinecticGym.DataBase;
using KinecticGym.Pantallas;
using KinecticGym.Pantallas.Pagos;
using Microsoft.AspNetCore.SignalR.Client;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas;
using PrototipoGym.Pantallas.Informes;
using PrototipoGym.Pantallas.Movimientos;
using PrototipoGym.Pantallas.Planes;

namespace PrototipoGym
{
    public partial class PantallaInicial : Form
    {
        // Atributos necesarios para la base de datos
        private DatabaseHelper databaseHelper;
        private gestorPlan gestorPlanSQL;
        private gestorCuenta gestorCuentaSQl;
        private gestorCliente gestorClienteSQL;
        private gestorMovimientos gestorMovimientosSQL;
        private gestorTipoMovmientos gestorTipoMovmientosSQL;

        //Pantalas
        Clientes clientesMainForm;
        planesMain planesMainForm;
        InformesMain informesMainForm;
        TipoMovimientosMain tipoMovimientoMainForm;
        MovimientosMain movimientosMainForm;
        principal principalForm;


        private ActualizacionesSignalR actualizacionesSignalR;




        public PantallaInicial()
        {
            try
            {
                InitializeComponent();
                cargarDb();
                iniciarPantallass();
                this.WindowState = FormWindowState.Maximized;
                this.Resize += Form1_Resize;




               actualizacionesSignalR = new ActualizacionesSignalR(databaseHelper, tipoMovimientoMainForm, movimientosMainForm, planesMainForm, clientesMainForm, principalForm);
               IniciarConexionSignalR();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el programa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            int margenX = 40; // Distancia del borde derecho
            int margenY = 40; // Distancia del borde inferior

            imagenPanel.Location = new Point(this.ClientSize.Width - imagenPanel.Width - margenX,
                                             this.ClientSize.Height - imagenPanel.Height - margenY);
        }
        private async void IniciarConexionSignalR()
        {
           await actualizacionesSignalR.StartConnectionAsync();
        }
        private void iniciarPantallass() 
        {

           clientesMainForm = new Clientes(gestorClienteSQL, gestorCuentaSQl, gestorMovimientosSQL, gestorPlanSQL, databaseHelper,gestorTipoMovmientosSQL);
            planesMainForm = new planesMain(databaseHelper, gestorPlanSQL,gestorTipoMovmientosSQL,gestorClienteSQL,gestorMovimientosSQL);
            informesMainForm = new InformesMain(gestorClienteSQL, gestorCuentaSQl, gestorMovimientosSQL, databaseHelper);
            tipoMovimientoMainForm = new TipoMovimientosMain(gestorTipoMovmientosSQL, databaseHelper);
            movimientosMainForm = new MovimientosMain(gestorMovimientosSQL,gestorCuentaSQl,gestorClienteSQL,databaseHelper,gestorTipoMovmientosSQL);
            principalForm = new principal(gestorClienteSQL,gestorMovimientosSQL,gestorPlanSQL,gestorCuentaSQl,gestorTipoMovmientosSQL,databaseHelper);

        }
        




        public void cargarDb()
        {
            databaseHelper = new DatabaseHelper();
            gestorPlanSQL = databaseHelper.CargarPlanesDeSQL(databaseHelper.ExecuteQuery("SELECT * FROM planes"));
            gestorTipoMovmientosSQL = databaseHelper.CargarTiposDeMovimientosSQL(databaseHelper.ExecuteQuery("SELECT * FROM tipomovimiento"));
            gestorCuentaSQl = databaseHelper.CargarCuentasSQL(databaseHelper.ExecuteQuery("SELECT * FROM cuentas"));
            gestorMovimientosSQL = databaseHelper.CargarMovimientosSQl(databaseHelper.ExecuteQuery("SELECT * FROM movimientos"), gestorTipoMovmientosSQL, gestorCuentaSQl);
            gestorClienteSQL = databaseHelper.CagarClientesSQL(databaseHelper.ExecuteQuery("SELECT * FROM clientes"), gestorPlanSQL, gestorCuentaSQl);
        }

        // Método para mostrar formularios dentro del panel contenedor
        private void mostrarFormularioEnPanel(Form form)


        {


            menuStrip1.Visible = false;

            // Crear el panel
            Panel panelContenedor = new Panel();
            

            // Configurar el tamaño y posición
            panelContenedor.Dock = DockStyle.Fill; // Hace que ocupe todo el espacio disponible

            panelContenedor.BackColor = Color.White;

            // Agregarlo al formulario principal o a otro contenedor
            this.Controls.Add(panelContenedor);


            panelContenedor.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel


            panelContenedor.Controls.Add(form);
            form.Show();
            panelContenedor.BringToFront();
            planesMainForm.actualizarGrid();
        }






        private void planesBtn_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(planesMainForm);
            planesMainForm.actualizarGrid();
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {
            // Evento Load de la ventana principal
            this.BackColor = Color.White; // O cualquier otro color que prefieras

        }

        private void checkPlanesBtn_Click(object sender, EventArgs e)
        {
            gestorPlanSQL.showPlanes();
        }




    
        private void clientesBtn_Click_1(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(clientesMainForm);
            clientesMainForm.actualizarGrid();

        }



        private void verCuentaBtn_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(informesMainForm);
        }

        private void tipoMovimientosBtn_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(tipoMovimientoMainForm);
            tipoMovimientoMainForm.actualizarGrid();
        }

        private void movimientoBtn_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(movimientosMainForm);
            movimientosMainForm.actualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           generarPago generarPagoForm = new generarPago(databaseHelper,gestorClienteSQL,gestorMovimientosSQL,gestorTipoMovmientosSQL);
           generarPagoForm.ShowDialog(Owner);
        }

        private void principalBtn_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(principalForm);
            
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(planesMainForm);
            planesMainForm.actualizarGrid();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(informesMainForm);


        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(movimientosMainForm);
            movimientosMainForm.actualizarGrid();
        }

        private void tipoDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(tipoMovimientoMainForm);
            tipoMovimientoMainForm.actualizarGrid();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularioEnPanel(clientesMainForm);
            clientesMainForm.actualizarGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
