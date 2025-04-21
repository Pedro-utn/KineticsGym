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
using PrototipoGym.Pantallas.Buscar;

namespace PrototipoGym.Pantallas.Movimientos
{
    public partial class MovimientosMain : Form
    {
        gestorMovimientos gestorMovimientos;
        gestorCliente gestorCliente;
        DatabaseHelper dbHelper;
        gestorCuenta gestorCuenta;
        gestorTipoMovmientos gestorTipoMovmientos;

        

        //Pantallas
        GenerarMovimiento generarMovimientoForm;
        BuscarMovimientos buscarMovimientoForm;
        modificarMovimiento  modificarClienteForm;
        public MovimientosMain(gestorMovimientos gestorMovimientos, gestorCuenta gestorCuenta, gestorCliente gestorCliente,
            DatabaseHelper dbHelper, gestorTipoMovmientos gestorTipoMovmientos)
        {
            InitializeComponent();
            this.gestorMovimientos = gestorMovimientos;            
            this.gestorCuenta = gestorCuenta;
            this.dbHelper = dbHelper;
            this.gestorCliente = gestorCliente;
            this.gestorTipoMovmientos = gestorTipoMovmientos;
            buscarMovimientoForm = new BuscarMovimientos(gestorMovimientos,gestorCliente);
            MostrarFormularioEnPanel(buscarMovimientoForm);
        }
        private void MostrarFormularioEnPanel(Form form)
        {
            panel.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel

            panel.Controls.Add(form);
            form.Show();
        }

        private void generarMovimientoBtn_Click(object sender, EventArgs e)
        {
            generarMovimientoForm = new GenerarMovimiento(gestorCliente,gestorTipoMovmientos,gestorCuenta, gestorMovimientos, dbHelper);
            generarMovimientoForm.FormClosed += actualizarGtid_FormClosed;
            generarMovimientoForm.ShowDialog();
        }


        private void MovimientosMain_Load(object sender, EventArgs e)
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

        private void actualizarGtid_FormClosed(object sender, EventArgs e) 
        {
            actualizarGrid();
        }
        public void actualizarGrid() 
        {
            buscarMovimientoForm.TxtBusqueda_TextChanged("", EventArgs.Empty);
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "¿Esta seguro que desea eliminar el movimiento?",
            "Aceptar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
);

            if (result == DialogResult.Yes)
            {
                Movimiento movimiento = buscarMovimientoForm.seleccionarMovimiento();

                gestorMovimientos.eliminarMovimiento(movimiento);

                // Borrar y corregir el saldo de la cuenta impactada.
                movimiento.getCuentaMov().eliminarMovimiento(movimiento);

                //SQL
                dbHelper.eliminarMovimiento(movimiento, movimiento.getCuentaMov().getSaldo());

                actualizarGrid();
            }
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movimiento movimientoSeleccionado = buscarMovimientoForm.getMovimientoSeleccionado();
            if (movimientoSeleccionado != null)
            {
                modificarClienteForm = new modificarMovimiento(movimientoSeleccionado,gestorCliente,dbHelper);
                modificarClienteForm.FormClosed += actualizarGtid_FormClosed;
                modificarClienteForm.ShowDialog();

            }
        }
    }
}
