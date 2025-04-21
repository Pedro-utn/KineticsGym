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

namespace PrototipoGym.Pantallas.Planes
{
    public partial class modificarPlan : Form
    {
        DatabaseHelper dbHelper;
        Plan plan;
        public modificarPlan(DatabaseHelper dbhelper, Plan plan)
        {
            dbHelper = dbhelper;
            this.plan = plan;
            InitializeComponent();
            placeHolderConfig();
        }
        private void placeHolderConfig()
        {
            ControlBox = false;

            idLb.Text = $"Nro Plan: {plan.getIdPlan()}";
            nombreTb.Text = $"{plan.getNombrePlan()}";
            descripcionTb.Text = $"{plan.getDescription()}";
            cuotaTb.Text = $"{plan.getCuota()}";

            // Estado
            if (plan.getEstado()) 
            {
                activoCb.Checked = true;
            }
            else
            {
                inactivoCb.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modificarPlanBtn_Click(object sender, EventArgs e)
        {
        
            // Limpiar espacios en blanco
            string nombreLimpio = nombreTb.Text?.Trim() ?? string.Empty;
            string descripcionLimpia = descripcionTb.Text?.Trim() ?? string.Empty;
            string cuotaLimpia = cuotaTb.Text?.Trim() ?? "0";

            // Convertir la cuota a float
            if (!float.TryParse(cuotaLimpia, out float nuevaCuota))
            {
                MessageBox.Show("La cuota ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string modificacionesStr = "Se realizarán las siguientes modificaciones: \n";
            bool hayModificaciones = false;

            // Verificar cambios
            if (!(plan.getNombrePlan().Equals(nombreLimpio)))
            {
                modificacionesStr += $"\nNombre: {plan.getNombrePlan()} --> {nombreLimpio}";
                hayModificaciones = true;
            }

            if (!(plan.getDescription().Equals(descripcionLimpia)))
            {
                modificacionesStr += $"\nDescripción: {plan.getDescription()} --> {descripcionLimpia}";
                hayModificaciones = true;
            }

            if (!(plan.getCuota().Equals(nuevaCuota)))
            {
                modificacionesStr += $"\nCuota: {plan.getCuota()} --> {nuevaCuota}";
                hayModificaciones = true;
            }
            if (!(plan.getEstado().Equals(activoCb.Checked))) 
            {
                modificacionesStr += $"\nEstado: {plan.getEstado()} --> {activoCb.Checked}";
                hayModificaciones = true;

            }

            // Si no hay cambios, mostrar mensaje y salir
            if (!hayModificaciones)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar mensaje de confirmación
            DialogResult resultado = MessageBox.Show(modificacionesStr,
                                                    "Confirmar Modificaciones",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question);

            // Si el usuario confirma, aplicar cambios
            if (resultado == DialogResult.OK)
            {
                if (!(plan.getNombrePlan().Equals(nombreLimpio)))
                {
                    plan.setNombre(nombreLimpio);
                }

                if (!(plan.getDescription().Equals(descripcionLimpia)))
                {
                    plan.setDescripcion(descripcionLimpia);
                }

                if (!(plan.getCuota().Equals(nuevaCuota)))
                {
                    plan.setCuota(nuevaCuota);
                }

                if (!(plan.getEstado().Equals(activoCb.Checked))) 
                {
                    plan.setEstado(activoCb.Checked);
                }


                    MessageBox.Show("Los cambios se aplicaron correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Guardar cambios en la base de datos
                dbHelper.modificarPlan(plan);

                this.Close();
            }
            else
            {
                MessageBox.Show("Se cancelaron los cambios", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

           
        

        private void modificarPlan_Load(object sender, EventArgs e)
        {

        }

        private void cuotaLb_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
