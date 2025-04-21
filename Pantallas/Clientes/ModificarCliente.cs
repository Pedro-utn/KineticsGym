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
    public partial class ModificarCliente : Form
    {
        private Cliente cliente;
        private Plan planSeleccionado;
        private Boolean estadoCliente;
        private gestorPlan planGestor;
        private DatabaseHelper dbHelper;
        public ModificarCliente(Cliente cliente,gestorPlan planGestor, DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.planGestor = planGestor;
            this.dbHelper = dbHelper;
            this.ControlBox = false;

            placeHolderTbConfig();
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }





        private void modificarBtn_Click(object sender, EventArgs e)
        {



            // Limpiamos los espacios en blanco de los campos de texto
            string nombreLimpio = nombreTb.Text?.Trim() ?? string.Empty;
            string telefonoLimpio = telefonoTb.Text?.Trim() ?? string.Empty;
            string modificacionesStr = "Se realizarán las siguientes modificaciones: \n";
            bool hayModificaciones = false;

            // Verificamos las modificaciones sin aplicarlas
            if (!(cliente.getNombre().Equals(nombreLimpio)))
            {
                modificacionesStr += $"\nNombre: {cliente.getNombre()} --> {nombreLimpio}";
                hayModificaciones = true;
            }

            if (!(cliente.getTelefono().Equals(telefonoLimpio)))
            {
                modificacionesStr += $"\nTeléfono: {cliente.getTelefono()} --> {telefonoLimpio}";
                hayModificaciones = true;
            }

            if (planSeleccionado != null && !cliente.getPlanAsociado().Equals(planSeleccionado))
            {
                modificacionesStr += $"\nPlan: {cliente.getPlanAsociado().getNombrePlan()} --> {planSeleccionado.getNombrePlan()}";
                hayModificaciones = true;
            }

            if (!(cliente.getEstado().Equals(estadoActivoCb.Checked)))
            {
                modificacionesStr += $"\nEstado: {(cliente.getEstado() ? "Activo" : "Inactivo")} --> {(estadoActivoCb.Checked ? "Activo" : "Inactivo")}";
                hayModificaciones = true;
            }

            // Si no hay modificaciones, mostramos mensaje y salimos
            if (!hayModificaciones)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostramos los cambios y pedimos confirmación
            DialogResult resultado = MessageBox.Show(modificacionesStr,
                                                   "Confirmar Modificaciones",
                                                   MessageBoxButtons.OKCancel,
                                                   MessageBoxIcon.Question);

            // Solo aplicamos los cambios si el usuario confirma
            if (resultado == DialogResult.OK)
            {
                if (!(cliente.getNombre().Equals(nombreLimpio)))
                {
                    cliente.setNombre(nombreLimpio);
                }

                if (!(cliente.getTelefono().Equals(telefonoLimpio)))
                {
                    cliente.setTelefono(telefonoLimpio);
                }

                if (planSeleccionado != null && !cliente.getPlanAsociado().Equals(planSeleccionado))
                {
                    cliente.setPlan(planSeleccionado);
                }

                if (!(cliente.getEstado().Equals(estadoActivoCb.Checked)))
                {
                    cliente.setEstado(estadoActivoCb.Checked);
                }

                // Finalmente se cierra el formulario y se guardad los cambios en la Db y se muestra el mensaje de que todo esta ok.

                dbHelper.modificarCliente(cliente);
                 
                MessageBox.Show("Los cambios se aplicaron correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();


            }
            else
            {
                MessageBox.Show("Se cancelaron los cambios", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }




        private void BuscarPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            var buscarPlanForm = sender as BuscarPlan;

            planSeleccionado = buscarPlanForm.getPlanSeleccionado();

            if (planSeleccionado != null)
            {
                planTb.Text = planSeleccionado.getNombrePlan();
                MessageBox.Show($"Plan seleccionado: {planSeleccionado.getNombrePlan()}");

            }
            else
            {
                MessageBox.Show("Formulario cerrado sin selección.");
            }
        }



        private void placeHolderTbConfig()
        {
            nombreTb.Text = cliente.getNombre();
            telefonoTb.Text = cliente.getTelefono();
            planTb.Text = cliente.getPlanAsociado().getNombrePlan();
            idLb.Text = $"Nro: {cliente.getId()}";

            if (cliente.getEstado())
            {
                estadoActivoCb.Checked = true;
            }
            else 
            {
                estadoInactivoCb.Checked = false;
            }

        }

        private void estadoActivoCb_CheckedChanged(object sender, EventArgs e)
        {
            estadoCliente = true;
        }

        private void estadoInactivoCb_CheckedChanged(object sender, EventArgs e)
        {
            estadoCliente = false;
        }

        private void buscarPlanBtn_Click(object sender, EventArgs e)
        {
            BuscarPlan buscarPlanForm = new BuscarPlan(planGestor);
            // Suscribir al evento FormClosed
            buscarPlanForm.FormClosed += BuscarPlan_FormClosed;
            buscarPlanForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
