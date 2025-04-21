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
    public partial class GenerarTipoMovimiento : Form
    {
        private bool tipo;
        private gestorTipoMovmientos gestorTipoMovmientos;
        DatabaseHelper dbSQL;
        public GenerarTipoMovimiento(gestorTipoMovmientos gestorTipoMovmientos, DatabaseHelper dbSQL)
        {
            InitializeComponent();
            this.gestorTipoMovmientos = gestorTipoMovmientos;
            this.dbSQL = dbSQL;
            this.ControlBox = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrarMovmientoBtn_Click(object sender, EventArgs e)
        {

            bool verificador = false;
            //Detalle
            string detalle = detalleTb.Text;

            if (string.IsNullOrEmpty(detalle))
            {
                MessageBox.Show("Ingrese un nombre");
                verificador = true;
            }
            if (debeCheckBox.Checked == reditoCheckBox.Checked) //Esta igualadad solo se da cuando no se selecciono ningun checkbox
            {
                verificador = true;
            }
            //ID
            int idNuevo = dbSQL.GetLastId("tipomovimiento", "idtipoMovimiento");
            //Instanciar el tipo si todo sale bien y se guarda
            if (verificador == false)
            {
                TipoMovmiento nuevoTipoMovimiento = new TipoMovmiento(detalle, idNuevo, tipo, true);

                gestorTipoMovmientos.addTipo(nuevoTipoMovimiento);
                //SQL
                dbSQL.insertarTipoMovimiento(nuevoTipoMovimiento);
                this.Close();


            }
            else
            {
                MessageBox.Show("Error al registrar falta datos!");
            }



        }

        private void debeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reditoCheckBox.Checked)
            {
                reditoCheckBox.Checked = false;
            }
            tipo = false;
        }

        private void reditoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (debeCheckBox.Checked) 
            {
                debeCheckBox.Checked = false;
            }
            tipo = true;
        }

        private void GenerarTipoMovimiento_Load(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
