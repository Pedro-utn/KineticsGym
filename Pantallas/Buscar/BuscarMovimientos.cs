using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.GestoresDeClase;

namespace PrototipoGym.Pantallas.Buscar
{
    public partial class BuscarMovimientos : Form
    {
        List<Movimiento> listaMovimientos;
        gestorMovimientos gestorMovimientos;
        gestorCliente gestorClientes;
        Movimiento movimientoSeleccionado;

        public BuscarMovimientos(gestorMovimientos gestorMovimientos, gestorCliente gestorClientes)
        {
            try
            {
            InitializeComponent();
            this.gestorMovimientos = gestorMovimientos;
            this.gestorClientes = gestorClientes;
            this.listaMovimientos = gestorMovimientos.getMovmientosList();
            listaMovimientos.Reverse();
            ConfigurarGrid();
            ConfigurarBuscador();

            } catch (Exception e)
            {
                MessageBox.Show($"Error al iniciar programa. {e}");
            }


        }

        private void BuscarMovimientos_Load(object sender, EventArgs e)
        {

        }
        public Movimiento seleccionarMovimiento()
        {
            if (movimientosDataGrid.SelectedRows.Count > 0)
            {
                // Obtén la primera fila seleccionada
                DataGridViewRow selectedRow = movimientosDataGrid.SelectedRows[0];

                // Accede a los valores de las celdas por columna
                int idSeleccionado = (int)selectedRow.Cells["Nro"].Value; // Reemplaza "IdColumn" con el nombre de tu columna
                                                                          //Obtiene el plan
                movimientoSeleccionado = gestorMovimientos.getMovimiento(idSeleccionado);

            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
            }
            return movimientoSeleccionado;
        }
        

 

        private void ConfigurarGrid()
        {
            movimientosDataGrid.AutoGenerateColumns = false;
            movimientosDataGrid.RowHeadersVisible = false;
            movimientosDataGrid.AllowUserToAddRows = false;
            movimientosDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            movimientosDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

            movimientosDataGrid.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            movimientosDataGrid.RowTemplate.Height = 35; // Establece la altura en píxeles



            movimientosDataGrid.Columns.Add("Nro", "Nro");
            movimientosDataGrid.Columns.Add("Fecha", "Fecha");
            movimientosDataGrid.Columns.Add("Detalle", "Detalle");
            movimientosDataGrid.Columns.Add("Destinatario", "Destinatario");
            movimientosDataGrid.Columns.Add("Monto", "Monto");

            movimientosDataGrid.Columns["Nro"].Width = 30;
            movimientosDataGrid.Columns["Fecha"].Width = 95;
            movimientosDataGrid.Columns["Monto"].Width = 80;
            movimientosDataGrid.Columns["Detalle"].Width = 130;
            movimientosDataGrid.Columns["Monto"].Width = 40;


            movimientosDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ActualizarGrid(listaMovimientos);
        }

        private void ConfigurarBuscador()
        {
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            ControlBox = false;
            movimientosDataGrid.ReadOnly = true;
        }

        public void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBusqueda.Text.Trim().ToLower();

            var resultados = listaMovimientos.Where(m =>
                m.getId().ToString().Contains(busqueda) ||
                gestorClientes.getCliente(m.getCuentaMov().getIdCuenta()).getNombre().ToLower().Contains(busqueda) ||
                m.getMonto().ToString().Contains(busqueda) ||
                m.getFecha().ToString().Contains(busqueda) ||
                m.getTipo().getDetalle().ToLower().Contains(busqueda)
            ).ToList();

            ActualizarGrid(resultados);
        }

        private void ActualizarGrid(List<Movimiento> datos)
        {
            movimientosDataGrid.Rows.Clear();


            foreach (var movimiento in datos)
            {
                int rowIndex = movimientosDataGrid.Rows.Add(
                    movimiento.getId(),
                    movimiento.getFecha().ToString(),
                    movimiento.getTipo().getDetalle(),
                    gestorClientes.getCliente(movimiento.getCuentaMov().getIdCuenta()).getNombre(),
                    movimiento.getMonto()
                );


            }

        }
        public Movimiento getMovimientoSeleccionado()
        {
            seleccionarMovimiento();
            return movimientoSeleccionado;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            movimientoSeleccionado = null;
            this.Close();
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            seleccionarMovimiento();
            this.Close();
        }
    }
}
