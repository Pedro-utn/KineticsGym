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

namespace PrototipoGym.Pantallas.Informes
{
    public partial class InformesMain : Form
    {
        SelectorDeInformes selectorInformesForm;
        gestorCliente gestorCliente;
        gestorCuenta gestorCuenta;
        gestorMovimientos gestorMovimientos;
        DatabaseHelper dbHelper;
        public InformesMain(gestorCliente gestorCLiente, gestorCuenta gestorCuenta, gestorMovimientos gestorMov, DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.gestorCliente = gestorCLiente; 
            this.gestorCuenta = gestorCuenta;
            this.gestorMovimientos = gestorMov;
            this.dbHelper = dbHelper;
            selectorInformesForm = new SelectorDeInformes(dbHelper,gestorCuenta,gestorCliente,gestorMovimientos);

            MostrarFormularioEnPanel(selectorInformesForm);
            volverBtn.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformesMain_Load(object sender, EventArgs e)
        {

        }
        private void MostrarFormularioEnPanel(Form form)
        {
            panel1.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel

            panel1.Controls.Add(form);
            form.Show();
        }

        private void visualizarInfomeBtn_Click(object sender, EventArgs e)
        {
            selectorInformesForm.iniciarVisor();
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
