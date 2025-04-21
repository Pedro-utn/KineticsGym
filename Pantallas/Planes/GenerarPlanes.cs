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

namespace PrototipoGym.Pantallas
{
    public partial class GenerarPlanes : Form
    {
        private gestorPlan gestorPlanes;
        private DatabaseHelper dbSQL;
        private int nroPlan;
        public GenerarPlanes(gestorPlan gestorPlanes,DatabaseHelper dbSQL)
        {
            InitializeComponent();
            this.gestorPlanes = gestorPlanes;
            this.dbSQL = dbSQL;
            configPlaceHolder();

        }
        private void configPlaceHolder() 
        {
            this.ControlBox = false;
            nroPlan = dbSQL.GetLastId("planes", "idplanes");
            idPlanLb.Text = $"Nro Plan: {nroPlan}";
        }




        private void generarPlanBtn_Click(object sender, EventArgs e)
        {
            //Toma los datos de cada text box
            //Bool que no permitira registrar en caso de error
            bool verificador = false;
            //Nombre
            string nombrePlanIngresado = nombrePlanTb.Text;

            if (string.IsNullOrEmpty(nombrePlanIngresado)) {
                MessageBox.Show("Ingrese un nombre");
                verificador = true;
            }

            //Cuota

            string cuotaIngresada = cuotaTb.Text;

            if (string.IsNullOrEmpty(cuotaIngresada)) {
                MessageBox.Show("Falta de ingresar una cuota.");
                verificador = true;

            }

            // Intentar convertir la entrada a float
            try
            {
                float numero = float.Parse(cuotaIngresada);
            }
            catch (FormatException)
            {
                // Este bloque se ejecuta si la conversión falla
                MessageBox.Show("Error: El valor ingresado no es un número válido.");
                verificador = true;

            }


            // Descripcion

            string descripcionPlanIngresada = descripcionTb.Text;

            //ID

            //Si todo sale bien se crea la instancia de plan.
            if (verificador == false)
            {
                Plan planNuevo = new Plan(nombrePlanIngresado, true, descripcionPlanIngresada, cuotaIngresada,nroPlan);

                // Se guarda el plan creado en el gestor que fue cargado previamente en pantalla incial
                gestorPlanes.cargarPlan(planNuevo);

                //SQL
                dbSQL.InsertarPlan(planNuevo);

                MessageBox.Show("Plan registrado");

                this.Close();

            }
            // De lo contrario se borran los escritos
            else {
                cuotaTb.Text = "";
                descripcionTb.Text = "";
                nombrePlanTb.Text = "";               
            }

        }

        private void GenerarPlanes_Load(object sender, EventArgs e)
        {
        }

        private void idPlanLb_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
