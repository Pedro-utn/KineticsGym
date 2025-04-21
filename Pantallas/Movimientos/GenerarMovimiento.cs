using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.Buscar;

namespace PrototipoGym.Pantallas
{
    public partial class GenerarMovimiento : Form
    {
        private gestorCliente clientesSQL;
        private gestorTipoMovmientos tipoMovimientosSQL;
        private gestorCuenta cuentasSQL;
        private gestorMovimientos movientosSQL;
        private DatabaseHelper dbSQL;
        private Cliente clienteSeleccionado;
        private Cuenta cuentaClienteSeleccionado;
        private TipoMovmiento tipoMovimientoSeleccionado;
        private DateTime fecha = new DateTime();
        private Movimiento movimientoNuevo;

        private float monto;
        private int idMovimiento;
        private bool validador = true;

        public GenerarMovimiento(gestorCliente clientesSQL, gestorTipoMovmientos tipoMovimientosSQL, gestorCuenta cuentasSQL, gestorMovimientos movientosSQL, DatabaseHelper dbSQL)
        {
            InitializeComponent();
            this.clientesSQL = clientesSQL;
            this.tipoMovimientosSQL = tipoMovimientosSQL;
            this.cuentasSQL = cuentasSQL;
            this.movientosSQL = movientosSQL;
            this.dbSQL = dbSQL;
            idMovimiento = dbSQL.GetLastId("movimientos", "idmovimientos");
        }

        



        private void cargarDb()
        {
            //Local. Se modifican los gestores para que todos tengan el movimiento con su impacto.
            movientosSQL.addMovmiento(movimientoNuevo);
            //SQL
            dbSQL.insertarMovmiento(movimientoNuevo);
            dbSQL.actualizarSaldoCuenta(cuentaClienteSeleccionado);
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCliente formBuscarCliente = new BuscarCliente(clientesSQL);

            //Suscripcion a evento de cierre
            formBuscarCliente.FormClosed += formBuscarCliente_FormClosed;
            
            formBuscarCliente.ShowDialog();

        }
        //Cuando se cierre la ventana de buscar cliente o buscar tipo. Se evaluara si se selecciono el objeto correspondiente.
        private void formBuscarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formBuscarCliente = sender as BuscarCliente;

            if (formBuscarCliente.getClienteSeleccionado() != null)
            {
                clienteSeleccionado = formBuscarCliente.getClienteSeleccionado();

                cuentaClienteSeleccionado = clienteSeleccionado.getCuenta();

                MessageBox.Show($"Plan seleccionado: {clienteSeleccionado.getNombre()}");

                clienteTb.Text = clienteSeleccionado.getNombre();
            }
            else
            {
                MessageBox.Show("Formulario cerrado sin selección.");
            }
        }

        private void buscarTIpoBtn_Click(object sender, EventArgs e)
        {
            BuscarTipoMov FormBuscarTipoMov = new BuscarTipoMov(tipoMovimientosSQL);

            FormBuscarTipoMov.FormClosed += FormBuscarTipoMov_FormClosed;

            FormBuscarTipoMov.Show();
        }

        private void FormBuscarTipoMov_FormClosed(object sender, FormClosedEventArgs e)
        {
            var FormBuscarTipoMov = sender as BuscarTipoMov;
            

            if (FormBuscarTipoMov.GetTipoMovmientoSeleccionado() != null)
            {
                tipoMovimientoSeleccionado = FormBuscarTipoMov.GetTipoMovmientoSeleccionado();
                MessageBox.Show($"Formulario cerrado. tipo de movimiento seleccionado: {tipoMovimientoSeleccionado.getDetalle()}");
                tipoTb.Text = tipoMovimientoSeleccionado.getDetalle();
            }
            else
            {
                MessageBox.Show("Formulario cerrado sin selección.");
            }
        }
        private float? validarYObtenerMonto()
        {
            string textoMonto = importeTb.Text.Trim(); // Obtiene el texto del TextBox
            float monto; // Variable donde se almacenará el monto convertido

            // Intentar convertir el texto a float
            if (float.TryParse(textoMonto, out monto))
            {
                if (monto > 0) // Verifica que el monto sea positivo
                {
                    return monto; // Retorna el monto válido
                }
                else
                {
                    MessageBox.Show("El monto ingresado debe ser mayor a 0.");
                    validador = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un monto válido en formato numérico.");
                validador = false;

            }

            // Si hay un error, retorna null
            return null;
        }

        

        private void grabarBTn_Click(object sender, EventArgs e)
        {

            // Se verifica de que el monto ingresado sea correcto
            monto = validarYObtenerMonto().Value; 
            

            if (validador) // En caso de que todo este bien. Se carga el movimiento.
            {
                movimientoNuevo = new Movimiento(cuentaClienteSeleccionado,idMovimiento,monto,tipoMovimientoSeleccionado);
                cargarDb();
                MessageBox.Show($"Movimiento Generado \n Nro: {idMovimiento}");
                this.Close();
            }
        }
       // Se controla que solo este seleccionado un unico checkBox 
      

        private void GenerarMovimiento_Load(object sender, EventArgs e)
        {
            
        }

        private void importeLb_Click(object sender, EventArgs e)
        {

        }

        private void idLb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
