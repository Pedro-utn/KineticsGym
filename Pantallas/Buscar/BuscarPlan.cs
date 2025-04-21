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

namespace PrototipoGym.Pantallas
{
    public partial class BuscarPlan : Form
    {
        private gestorPlan gestorPlanes;
        private Plan planSeleccionado;
        public BuscarPlan(gestorPlan planesSQL)
        {
            InitializeComponent();
            this.gestorPlanes = planesSQL;
            ConfigurarGrid();
            ConfigurarBuscador();

            
        }


        private void ConfigurarGrid()
        {
            planesDataGrid.AutoGenerateColumns = false;
            planesDataGrid.RowHeadersVisible = false;
            planesDataGrid.AllowUserToAddRows = false;

            planesDataGrid.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            planesDataGrid.RowTemplate.Height = 35; // Establece la altura en píxeles


            planesDataGrid.Columns.Add("Nro", "Nro");
            planesDataGrid.Columns.Add("Nombre", "Plan");
            planesDataGrid.Columns.Add("Descripcion", "Descripción");
            planesDataGrid.Columns.Add("Cuota", "Cuota");
            planesDataGrid.Columns.Add("Estado", "Estado");

            planesDataGrid.Columns["Nro"].Width = 30;
            planesDataGrid.Columns["Cuota"].Width = 30;
            planesDataGrid.Columns["Estado"].Width = 30;
            planesDataGrid.Columns["Descripcion"].Width = 310;
            planesDataGrid.Columns["Nombre"].Width = 220;



            planesDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Color de fondo al seleccionar
            planesDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black; // Color del texto al seleccionar

            planesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            planesDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            ActualizarGrid(gestorPlanes.getPlanList());


        }

        private void ConfigurarBuscador()
        {
            ControlBox = false;
            planesDataGrid.ReadOnly = true;
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
        }

        public void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBusqueda.Text.Trim().ToLower();

            var resultados = gestorPlanes.getPlanList().Where(p =>
                p.getNombrePlan().ToLower().Contains(busqueda) ||
                p.getDescription().ToLower().Contains(busqueda) ||
                p.getIdPlan().ToString().Contains(busqueda)
            ).ToList();

            ActualizarGrid(resultados);
        }

        private void ActualizarGrid(List<Plan> datos)
        {
            planesDataGrid.Rows.Clear();

            // Ordenar: primero los activos (true), luego los inactivos (false)
            var datosOrdenados = datos.OrderByDescending(p => p.getEstado()).ToList();

            foreach (var plan in datosOrdenados)
            {
                string descripcionCortada = plan.getDescription().Length > 20
                    ? plan.getDescription().Substring(0, 20) + "..."
                    : plan.getDescription();

                int rowIndex = planesDataGrid.Rows.Add(
                    plan.getIdPlan(),
                    plan.getNombrePlan(),
                    descripcionCortada,
                    plan.getCuota(),
                    plan.getEstado() ? "Activo" : "Inactivo"
                );

                // Si está inactivo, colorear de rojo
                if (!plan.getEstado())
                {
                    planesDataGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    planesDataGrid.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }


        public Plan seleccionarPlan() 
        {
            // Verifica que haya una fila seleccionada
            if (planesDataGrid.SelectedRows.Count > 0)
            {
                // Obtén la primera fila seleccionada
                DataGridViewRow selectedRow = planesDataGrid.SelectedRows[0];

                // Accede a los valores de las celdas por columna
                int idSeleccionado = (int)selectedRow.Cells["Nro"].Value; // Reemplaza "IdColumn" con el nombre de tu columna
                //Obtiene el plan
                planSeleccionado = gestorPlanes.getPlan(idSeleccionado);

            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
            }
            return planSeleccionado;
        
        }

        public Plan getPlanSeleccionado()
        {
            return planSeleccionado;
        }
           

        private void buscarPlanLb_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPlan_Load(object sender, EventArgs e)
        {

        }

        public void ocultarBotones()
        {
            seleccionarBtn.Visible = false;
            cancelarBtn.Visible = false;


        }

        private void planesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            planSeleccionado = null;
            txtBusqueda.Text = "";
            this.Close();
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            seleccionarPlan();
            this.Close();
        }
    }
}

