using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.TipoMovimientos;

namespace PrototipoGym.Pantallas.Planes
{
    public partial class planesMain : Form
    {
        DatabaseHelper dbHelper;
        gestorPlan gestorPlan;
        GenerarPlanes generarPlanForm;
        BuscarPlan buscarPlanForm;
        modificarPlan modificarPlanForm;

        gestorMovimientos gestorMovimientos;
        gestorTipoMovmientos gestorTipoMovimiento;
        gestorCliente gestorCliente;

        public planesMain(DatabaseHelper dbHelper, gestorPlan gestorPlan,gestorTipoMovmientos gestorTipoMovmientos, gestorCliente gestorCliente, gestorMovimientos gestorMovimientos)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.gestorPlan = gestorPlan;
            this.gestorTipoMovimiento = gestorTipoMovmientos;
            this.gestorCliente = gestorCliente;
            this.gestorMovimientos = gestorMovimientos;
            panelConfig();
        }



        private void planesMain_Load(object sender, EventArgs e)
        {

        }
        private void panelConfig() 
        {
            buscarPlanForm = new BuscarPlan(gestorPlan);
            mostrarFormularioEnPanel(buscarPlanForm);
        }
        private void mostrarFormularioEnPanel(Form form)
        {
            buscarPlanPanel.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            form.TopLevel = false;  // Hace que no sea una ventana independiente
            form.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de ventana
            form.Dock = DockStyle.Fill; // Hace que ocupe todo el panel

            buscarPlanPanel.Controls.Add(form);
            buscarPlanForm.ocultarBotones();
            form.Show();
        }
        private void ActualizarGid_FormClosed(object sender, FormClosedEventArgs e)
        {

            actualizarGrid();
        }
        public void actualizarGrid() 
        {
            //Actualizacion artifical del dataGrid.
            buscarPlanForm.TxtBusqueda_TextChanged("", EventArgs.Empty);
        }



        private void nuevoPlanBtn_Click(object sender, EventArgs e)
        {
            generarPlanForm = new GenerarPlanes(gestorPlan, dbHelper);
            generarPlanForm.FormClosed += ActualizarGid_FormClosed;
            generarPlanForm.ShowDialog();
        }

        private void modificarPlanBtn_Click(object sender, EventArgs e)
        {
            if (dbHelper.ExisteGenCuotaDelMesActual())
            {
                MessageBox.Show("No podra modificar los planes, ya que las cuotas del mes presente estan generadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modificarPlanForm = new modificarPlan(dbHelper,buscarPlanForm.seleccionarPlan());
            modificarPlanForm.FormClosed += ActualizarGid_FormClosed;

            modificarPlanForm.ShowDialog();
        }

        private void buscarPlanPanel_Paint(object sender, PaintEventArgs e)
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

        private void cobrarPlanes_Click(object sender, EventArgs e)
        {
            bool existe = false;
            TipoMovmiento tipoMovimiento = null;
            //Primero se genera un tipo de movimiento "generarCuota" si es que es la primer vez que se cobra una.
            foreach (TipoMovmiento tipoMov in gestorTipoMovimiento.getTipoMovmientosList())  
            { 
                if (tipoMov.getDetalle() == "Generacion de Cuota")
                {
                    tipoMovimiento = tipoMov;
                    existe = true;
                }
            }
            if (existe == false) 
            {
                tipoMovimiento = new TipoMovmiento("Generacion de Cuota",dbHelper.GetLastId("Planes", "idplanes"),false,true);
                dbHelper.insertarTipoMovimiento(tipoMovimiento);
            }
            foreach (Cliente cliente in gestorCliente.getClienteList())
            {
                Movimiento movimientoNuevo = new Movimiento(cliente.getCuenta(),cliente.getId(),cliente.getPlanAsociado().getCuota(),tipoMovimiento);
                
                gestorMovimientos.addMovmiento(movimientoNuevo);
                //SQL
                dbHelper.insertarMovmiento(movimientoNuevo);
                dbHelper.actualizarSaldoCuenta(cliente.getCuenta());
            }

            MessageBox.Show("Cuotas generadas");
            actualizarGrid();
        }

        private void generarCuota_Click(object sender, EventArgs e)
        {
              
            // Comparar el mes de la fecha actual con el mes de ultimaGenCuota
            if (dbHelper.ExisteGenCuotaDelMesActual())
            {
                MessageBox.Show("La cuota de este mes ya ha sido generada." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult result = MessageBox.Show(
                "¿Seguro que desea realizar la generación de cuotas? Revise las cuotas.",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.No)
            {
                return;
            }




            foreach (Cliente cliente in gestorCliente.getClienteList())
            {
                TipoMovmiento cuotaTipoMov = gestorTipoMovimiento.validarExistenciaTipoMov("Generacion Cuota", false);
                if (cliente.getEstado() == true)
                {
                    Cuenta cuenta = cliente.getCuenta();
                    float importe = cliente.getPlanAsociado().getCuota();


                    Movimiento generacionCuota = new Movimiento(cuenta, dbHelper.GetLastId("movimientos", "idmovimientos"), importe, cuotaTipoMov);

                    //Se guarda en local y sql

                    gestorMovimientos.addMovmiento(generacionCuota);
                    dbHelper.insertarMovmiento(generacionCuota);

                }
            }
            MessageBox.Show("Cuotas Generadas");

            //Se geenera la instacia de gencuota

            dbHelper.InsertarGenCuota(DateTime.Now, GenerarJsonPlanes(gestorPlan.getPlanList()));
            actualizarGrid();
        }
        private string GenerarJsonPlanes(List<Plan> planes)
        {
            try
            {
                return JsonSerializer.Serialize(planes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"⚠️ Error al generar el JSON de planes:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return string.Empty;
            }
        }

    }

}
