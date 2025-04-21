using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinecticGym.Clases;
using MySqlX.XDevAPI;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;

namespace PrototipoGym.Pantallas.Movimientos
{
    public partial class modificarMovimiento : Form
    {
        private Movimiento movimiento;
        private gestorCliente gestorCliente;
        private DatabaseHelper dbHelper;

        //Atributos modifados
        DateTime fechaNueva;        
        int medioNuevo;
        

        public modificarMovimiento(Movimiento movimiento, gestorCliente gestorCliente,DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.gestorCliente = gestorCliente;
            this.movimiento = movimiento;
            cargarMovimiento();
        }

        private void cargarMovimiento() 
        {
            fechaNueva = movimiento.getFecha();

            //Pantalla
            this.MouseDown += BajarCuestionario_MouseDown;
            this.calendario.DateSelected += monthCalendar1_DateSelected;

            //Movimiento
            numeroMovimientoTb.Text = $"{movimiento.getId()}";
            tipoMovimientoTb.Text = movimiento.getTipo().getDetalle();
            importeTb.Text = $"{movimiento.getMonto()}";
            clienteTb.Text = gestorCliente.getCliente(movimiento.getCuentaMov().getIdCuenta()).getNombre();
            fechaTb.Text = $"{movimiento.getFecha().ToShortDateString()}";
            calendario.SelectionStart = movimiento.getFecha();

            if (movimiento is Pago pago)
            {
                efectivoCb.Visible = true;
                tranferenciaTb.Visible = true;
                medioLb.Visible = true;

                if (pago.getMedioPago() == 1) 
                {
                    efectivoCb.Checked = true;
                }
                else if (pago.getMedioPago() == 2) 
                {
                    tranferenciaTb.Checked = true;
                }
            }


        }

        private void modificarMovimiento_Load(object sender, EventArgs e)
        {

        }
        private void BajarCuestionario_MouseDown(object sender, MouseEventArgs e)
        {
            if (calendario.Visible) 
            {
                calendario.Visible = false;
                modificarFechaBtn.Visible = true;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaTb.Text = (calendario.SelectionStart.ToShortDateString());
            fechaNueva = calendario.SelectionStart;
        }


        private void modificarFechaBtn_Click(object sender, EventArgs e)
        {
            modificarFechaBtn.Visible = false;
            calendario.Visible = true;

        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            // Se corrobora que lo ingresado sea correcto.
            if (!float.TryParse(importeTb.Text, out float importeNuevo))
            {
                MessageBox.Show("Importe no válido.");
                return;
            }

            string modificacionesStr = "Se realizarán las siguientes modificaciones: \n";
            bool hayModificaciones = false;

            // Verificamos las modificaciones sin aplicarlas
            // Fecha
            if (!movimiento.getFecha().Equals(fechaNueva))
            {
                modificacionesStr += $"\n Fecha: {movimiento.getFecha().ToShortDateString()} --> {fechaNueva}";
                hayModificaciones = true;
            }
            // Importe
            if (!movimiento.getMonto().Equals(importeNuevo))
            {
                modificacionesStr += $"\n Importe: {movimiento.getMonto()} --> {importeNuevo}";
                hayModificaciones = true;
            }

            // Verificamos si el movimiento es un Pago y si el medio de pago ha cambiado
            if (movimiento is Pago pago && pago.getMedioPago() != medioNuevo)
            {
                modificacionesStr += $"\n Medio de pago: {(pago.getMedioPago() == 1 ? "Efectivo" : "Transferencia")} --> {(medioNuevo == 1 ? "Efectivo" : "Transferencia")}";
                hayModificaciones = true;
            }

            // Si no hay modificaciones, mostramos mensaje y salimos
            if (!hayModificaciones)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostramos los cambios y pedimos confirmación
            DialogResult resultado = MessageBox.Show(modificacionesStr, "Confirmar Modificaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Solo aplicamos los cambios si el usuario confirma
            if (resultado == DialogResult.OK)
            {
                if (!movimiento.getFecha().Equals(fechaNueva))
                {
                    movimiento.setFecha(fechaNueva);
                }

                if (!movimiento.getMonto().Equals(importeNuevo))
                {
                    movimiento.setImporte(importeNuevo);
                    //Actualizamos la cuenta.
                    movimiento.getCuentaMov().actualizarSaldo();
                }

                // Aplicamos el cambio de medio de pago si corresponde
                if (movimiento is Pago pagoModificado && pagoModificado.getMedioPago() != medioNuevo)
                {
                    pagoModificado.setMedio(medioNuevo);
                }

           

                // Guardamos los cambios en la base de datos
                dbHelper.modificarMovimiento(movimiento);

                MessageBox.Show("Los cambios se aplicaron correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Se cancelaron los cambios", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void efectivoCb_CheckedChanged(object sender, EventArgs e)
        {
            medioNuevo = 1;
        }

        private void tranferenciaTb_CheckedChanged(object sender, EventArgs e)
        {
            medioNuevo = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
