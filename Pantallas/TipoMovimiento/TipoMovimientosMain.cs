using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.Buscar;
using PrototipoGym.Pantallas.TipoMovimientos;

namespace PrototipoGym.Pantallas.Movimientos
{
    public partial class TipoMovimientosMain : Form
    {
        //Datos
        DatabaseHelper dbHelper;
        gestorTipoMovmientos gestorTipoMovimientos;

        //Pantallas
        GenerarTipoMovimiento nuevoTipoMovimientoForm;
        BuscarTipoMov buscarTipoMovForm;

        public TipoMovimientosMain(gestorTipoMovmientos gestorTipoMovmientos, DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.gestorTipoMovimientos = gestorTipoMovmientos;
            this.dbHelper = dbHelper;

            buscarTipoMovForm = new BuscarTipoMov(gestorTipoMovimientos);
            mostrarFormularioEnPanel(buscarTipoMovForm);

        }

        private void nuevoMovimientoBtn_Click(object sender, EventArgs e)
        {
            nuevoTipoMovimientoForm = new GenerarTipoMovimiento(gestorTipoMovimientos,dbHelper);
            nuevoTipoMovimientoForm.FormClosed += actualizarGrid_FormClosed;
            nuevoTipoMovimientoForm.ShowDialog();
        }
        private void mostrarFormularioEnPanel(Form form)
        {
            panel1.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel

            panel1.Controls.Add(form);
            buscarTipoMovForm.ocultarBotones();
            form.Show();
        }
        private void actualizarGrid_FormClosed(object sender, FormClosedEventArgs e) 
        {
            actualizarGrid();
        }
        public void actualizarGrid() 
        {
            //Actualizacion artifical del dataGrid.
            buscarTipoMovForm.tipoMovTb_TextChanged("", EventArgs.Empty);
        }



        private void modificarMovimientoBtn_Click(object sender, EventArgs e)
        {
            ModificarTipoMovimeinto modificarTipoMovimientoForm = new ModificarTipoMovimeinto(buscarTipoMovForm.seleccionarCliente(), dbHelper,gestorTipoMovimientos);
            modificarTipoMovimientoForm.FormClosed += actualizarGrid_FormClosed;
            modificarTipoMovimientoForm.ShowDialog();
        }

        private void TipoMovimientosMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
            PantallaInicial mainForm = this.ParentForm as PantallaInicial;
            if (mainForm != null)
            {
                mainForm.menuStrip1.Visible = true; // Ejemplo de acceso
            }
        }
    }
}
