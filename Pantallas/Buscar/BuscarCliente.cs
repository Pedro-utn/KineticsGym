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
using PrototipoGym.GestoresDeClase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrototipoGym.Pantallas
{
    public partial class BuscarCliente : Form
    {
        private gestorCliente gestorClientes;
        private Cliente clienteSeleccionado;
        public BuscarCliente(gestorCliente gestorCliente)
        {
            InitializeComponent();
            this.AcceptButton = seleccionarBtn;

            this.gestorClientes = gestorCliente;

            ConfigurarGrid();
            ConfigurarBuscador();
        }
        private void ConfigurarGrid()
        {
            clientesDataGrid.AutoGenerateColumns = false;
            clientesDataGrid.RowHeadersVisible = false;
            clientesDataGrid.AllowUserToAddRows = false;
            clientesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientesDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

            clientesDataGrid.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            clientesDataGrid.RowTemplate.Height = 35; // Establece la altura en píxeles


            clientesDataGrid.Columns.Add("Id", "ID");
            clientesDataGrid.Columns.Add("Nombre", "Nombre");
            clientesDataGrid.Columns.Add("Telefono", "Teléfono");
            clientesDataGrid.Columns.Add("Plan", "Plan");
            clientesDataGrid.Columns.Add("Estado", "Estado");
            clientesDataGrid.Columns.Add("Saldo", "Saldo");

            clientesDataGrid.Columns["Id"].Width = 40;
            clientesDataGrid.Columns["Telefono"].Width = 120;
            clientesDataGrid.Columns["Nombre"].Width = 150;
            clientesDataGrid.Columns["Plan"].Width = 150;
            clientesDataGrid.Columns["Estado"].Width = 80;
            clientesDataGrid.Columns["Saldo"].Width = 100;




            clientesDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Color de fondo al seleccionar
            clientesDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black; // Color del texto al seleccionar

            clientesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActualizarGrid(gestorClientes.getClienteList());
        }
        private void ConfigurarBuscador()
        {
            ControlBox = false;
            clientesDataGrid.ReadOnly = true;
            buscarClienteTb.TextChanged += buscarClienteTb_TextChanged;

        }
        public void ocultarBotones() 
        {
            seleccionarBtn.Visible= false;
            cancelarBtn.Visible= false;
      
        }
        public void buscarClienteTb_TextChanged(object sender, EventArgs e)
        {
            string busqueda = buscarClienteTb.Text.Trim().ToLower();

            var resultados = gestorClientes.getClienteList().Where(c =>
                c.getNombre().ToLower().Contains(busqueda) ||
                c.getId().ToString().Contains(busqueda)
            ).ToList();

            ActualizarGrid(resultados);
        }
        public void actualizarGridPublico()
        {
            buscarClienteTb.Text = " ";
                    }
        private void ActualizarGrid(List<Cliente> clientes)
        {
            clientesDataGrid.Rows.Clear();

            // Ordenar: primero los activos (true), luego los inactivos (false)
            var clientesOrdenados = clientes.OrderByDescending(c => c.getEstado()).ToList();

            foreach (var cliente in clientesOrdenados)
            {

                 int rowIndex = clientesDataGrid.Rows.Add(
                    cliente.getId(),
                    cliente.getNombre(),
                    cliente.getTelefono(),
                    cliente.getPlanAsociado().getNombrePlan(),
                    cliente.getEstado() ? "Activo" : "Inactivo",
                    cliente.getCuenta().getSaldo()
                );

                // Si está inactivo, colorear de rojo
                if (!cliente.getEstado())
                {
                    clientesDataGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    clientesDataGrid.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        public Cliente getClienteSeleccionado()
        {        
            return clienteSeleccionado;
        }


        private void BuscarCliente_Load(object sender, EventArgs e)
        {

        }


        private void clientesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            this.Close();
        }
        public Cliente seleccinoarCliente() 
        {
            if (clientesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = clientesDataGrid.SelectedRows[0];
                int idSeleccionado = (int)selectedRow.Cells["Id"].Value;
                clienteSeleccionado = gestorClientes.getCliente(idSeleccionado);
                return clienteSeleccionado;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente.");
                return null;
            }
        }



        private void seleccionarBtn_Click_1(object sender, EventArgs e)
        {
            seleccinoarCliente();
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            buscarClienteTb.Text = "";
            this.Close();
        }
    }
}
