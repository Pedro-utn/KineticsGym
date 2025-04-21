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

namespace PrototipoGym.Pantallas.TipoMovimientos
{
    public partial class ModificarTipoMovimeinto : Form
    {
        //Datos
        TipoMovmiento tipoMovimiento;
        gestorTipoMovmientos gestorTipoMovimientos;
        DatabaseHelper dbHelper;
        bool estadoSeleccionado;
        public ModificarTipoMovimeinto(TipoMovmiento tipoMovmiento, DatabaseHelper dbHelper,gestorTipoMovmientos gstorTipoMovimientos)
        {
            InitializeComponent();

            this.tipoMovimiento = tipoMovmiento;
            this.dbHelper = dbHelper;
            this.gestorTipoMovimientos = gstorTipoMovimientos;
            configPlaceHolder();
        }

        private void modificarTipoMovimeinto_Load(object sender, EventArgs e)
        {

        }
        private void configPlaceHolder() 
        {
            ControlBox = false;
            nombreTipoMovTb.Text = tipoMovimiento.getDetalle();
            idLb.Text = $"Nro TipMov: {tipoMovimiento.getId()}";
            reditoCb.Checked = tipoMovimiento.getTipoBool();
            
            estadoSeleccionado = tipoMovimiento.getEstado();
            modificarEstadoBtnLb();

        }
        private void modificarEstadoBtnLb() 
        {
            if (estadoSeleccionado)
            {
                estadoBtn.Text = "Inhabilitar";
                estadoBtn.BackColor = Color.Red;
                estadoBtn.ForeColor = Color.White;

            }
            else 
            {
                estadoBtn.Text = "Hablitar";
                estadoBtn.BackColor = Color.LightGreen;
                estadoBtn.ForeColor = Color.Black;

            }
        }



        private void modificarTIpoMovimientoBtn_Click(object sender, EventArgs e)
        {
            // Limpiar espacios en blanco
            string detalleLimpio = nombreTipoMovTb.Text?.Trim() ?? string.Empty;
            bool nuevoTipo = reditoCb.Checked; 

            string modificacionesStr = "Se realizarán las siguientes modificaciones: \n";
            bool hayModificaciones = false;

            // Verificar cambios
            if (!(tipoMovimiento.getDetalle().Equals(detalleLimpio)))
            {
                modificacionesStr += $"\nDetalle: {tipoMovimiento.getDetalle()} --> {detalleLimpio}";
                hayModificaciones = true;
            }

            if (!(tipoMovimiento.getTipoBool().Equals(nuevoTipo)))
            {
                modificacionesStr += $"\nTipo: {(tipoMovimiento.getTipoBool() ? "Ingreso" : "Egreso")} --> {(nuevoTipo ? "Ingreso" : "Egreso")}";
                hayModificaciones = true;
            }
            if (tipoMovimiento.getEstado() != estadoSeleccionado)
            {
                modificacionesStr +=  $"\nEstado: {(tipoMovimiento.getEstado() ? "Habilitado" : "Inhabilitado")} -->{(estadoSeleccionado ? "Habilitado" : "Inhabilitado")} ";
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
                if (!(tipoMovimiento.getDetalle().Equals(detalleLimpio)))
                {
                    tipoMovimiento.setDetalle(detalleLimpio);
                }

                if (!(tipoMovimiento.getTipoBool().Equals(nuevoTipo)))
                {
                    tipoMovimiento.setTipo(nuevoTipo);
                }
                if (tipoMovimiento.getEstado() != estadoSeleccionado)
                {
                    tipoMovimiento.setEstado(estadoSeleccionado);
                }


                    MessageBox.Show("Los cambios se aplicaron correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Guardar cambios en la base de datos
                dbHelper.modificarTipoMovimiento(tipoMovimiento);

                this.Close();
            }
            else
            {
                MessageBox.Show("Se cancelaron los cambios", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void estadoBtn_Click(object sender, EventArgs e)
        {
            estadoSeleccionado = !estadoSeleccionado;
            modificarEstadoBtnLb();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}