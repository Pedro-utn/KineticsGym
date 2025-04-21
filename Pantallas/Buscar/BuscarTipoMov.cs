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
using MySqlX.XDevAPI;
using PrototipoGym.Clases;
using PrototipoGym.GestoresDeClase;

namespace PrototipoGym.Pantallas.Buscar
{
    public partial class BuscarTipoMov : Form
    {
        private gestorTipoMovmientos TipoMovmientosSQL;
        private TipoMovmiento tipoMovmientoSeleccionado;
        public BuscarTipoMov(gestorTipoMovmientos gestorTipoMovimento)
        {
            InitializeComponent();
            this.TipoMovmientosSQL = gestorTipoMovimento;
            ConfigurarGrid();
            ConfigurarBuscador();


        }

        public void ConfigurarGrid()
        {
            tipoMovDataGrid.AutoGenerateColumns = false;
            tipoMovDataGrid.RowHeadersVisible = false;
            tipoMovDataGrid.AllowUserToAddRows = false;

            tipoMovDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tipoMovDataGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tipoMovDataGrid.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            tipoMovDataGrid.RowTemplate.Height = 35; // Establece la altura en píxeles



            tipoMovDataGrid.Columns.Add("id", "Nro");
            tipoMovDataGrid.Columns.Add("Detalle", "Detalle");
            tipoMovDataGrid.Columns.Add("tipo","Impacto");
            tipoMovDataGrid.Columns.Add("estado", "Estado");

            tipoMovDataGrid.Columns["id"].Width = 25;
            tipoMovDataGrid.Columns["tipo"].Width = 30;
            tipoMovDataGrid.Columns["estado"].Width = 80;
            tipoMovDataGrid.Columns["Detalle"].Width = 500;


            tipoMovDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray; // Color de fondo al seleccionar
            tipoMovDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black; // Color del texto al seleccionar


            tipoMovDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ActualizarGrid(TipoMovmientosSQL.getTipoMovmientosList());

        }

        public void ConfigurarBuscador()
        {
            //Se realiza la asociacion a la accion 
            tipoMovTb.TextChanged += tipoMovTb_TextChanged;
        }

        public void tipoMovTb_TextChanged(object sender, EventArgs e)
        {
            string busqueda = tipoMovTb.Text.Trim().ToLower();

            var resultados = TipoMovmientosSQL.getTipoMovmientosList().Where(p =>
                p.getId().ToString().Contains(busqueda) ||
                p.getDetalle().ToLower().Contains(busqueda)
            ).ToList();

            ActualizarGrid(resultados);
        }

        private void ActualizarGrid(List<TipoMovmiento> datos)
        {
            tipoMovDataGrid.Rows.Clear();

            // Ordenar: primero los habilitados (true), luego los inhabilitados (false)
            var datosOrdenados = datos.OrderByDescending(t => t.getEstado()).ToList();

            foreach (var TipoMovmiento in datosOrdenados)
            {
                int rowIndex = tipoMovDataGrid.Rows.Add(
                    TipoMovmiento.getId(),
                    TipoMovmiento.getDetalle(),
                    TipoMovmiento.getTipoBool() ? "Redito" : "Debe",
                    TipoMovmiento.getEstado() ? "Habilitado" : "Inhabilitado"
                );

                // Si está inhabilitado, colorear de rojo
                if (!TipoMovmiento.getEstado())
                {
                    tipoMovDataGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    tipoMovDataGrid.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }




        private void BuscarTipoMov_Load(object sender, EventArgs e)
        {

        }

        public void ocultarBotones()
        {
            ControlBox = false;
            tipoMovDataGrid.ReadOnly = true;

            seleccionarBtn.Visible = false;
            cancelarBtn.Visible = false;


        }



        public TipoMovmiento GetTipoMovmientoSeleccionado() 
        {
            return tipoMovmientoSeleccionado;
        }
        public TipoMovmiento seleccionarCliente() 
        {
            // Verifica que haya una fila seleccionada
            if (tipoMovDataGrid.SelectedRows.Count > 0)
            {
                // Obtén la primera fila seleccionada
                DataGridViewRow selectedRow = tipoMovDataGrid.SelectedRows[0];

                // Accede a los valores de las celdas por columna
                int idSeleccionado = (int)selectedRow.Cells["Id"].Value; // Reemplaza "IdColumn" con el nombre de tu columna
                //Obtiene el plan
                tipoMovmientoSeleccionado = TipoMovmientosSQL.getTipoMov(idSeleccionado);

            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas.");
            }
            return tipoMovmientoSeleccionado;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            tipoMovmientoSeleccionado = null;
            tipoMovTb.Text = "";
            this.Close();
        }

        private void seleccionarBtn_Click_1(object sender, EventArgs e)
        {
            this.seleccionarCliente();
            this.Close();
        }

        private void tipoMovDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
