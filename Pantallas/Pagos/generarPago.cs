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
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas;

namespace KinecticGym.Pantallas.Pagos
{
    public partial class generarPago : Form
    {
        //Variables
        Cliente clienteSeleccionado;
        int mediopago = 4;
        float monto;
        int idPago;
        float montoDescuento;
        float montoPago;
        Movimiento movmientoDescuento;
        bool errores;
       

        //Gestores
        gestorCliente gestorCliente;
        gestorMovimientos gestorMovimientos;
        gestorTipoMovmientos gestorTipoMovmientos;
       
        DatabaseHelper dbHelper;

        //Formularios
        BuscarCliente buscarClienteForm;
        public generarPago(DatabaseHelper dbHelper, gestorCliente gestorCliente, gestorMovimientos gestorMovimientos, gestorTipoMovmientos gestorTipoMovmientos)
        {
            this.dbHelper = dbHelper;
            this.gestorCliente = gestorCliente;
            this.gestorMovimientos = gestorMovimientos;
            this.gestorTipoMovmientos = gestorTipoMovmientos;
            errores = false;


            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            buscarClienteForm = new BuscarCliente(gestorCliente);
            buscarClienteForm.FormClosed += BuscarClienteForm_FormClosed;
            buscarClienteForm.ShowDialog();
        }

        private void BuscarClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se guarda el cliente seleccionado
            
            clienteSeleccionado = buscarClienteForm.getClienteSeleccionado();
            if (clienteSeleccionado != null) 
            {
            clienteTb.Text = clienteSeleccionado.getNombre();

            }
        }

        private void efectivoCb_CheckedChanged(object sender, EventArgs e)
        {
            mediopago = 1;
        }

        private void tranferenciaCb_CheckedChanged(object sender, EventArgs e)
        {
            mediopago = 2;
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            errores = false;
            //Cliente 
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente");
                errores = true;
            }

            bool descuento = false;
            // Descuento
            if (!string.IsNullOrWhiteSpace(descuentoTb.Text))// Entra en caso de que haya algo dento de descuentoTb
            {
                descuentoTb.Text = descuentoTb.Text.Trim();

                // Intentar convertir el texto a float
                if (float.TryParse(descuentoTb.Text, out _))
                { 
                    montoDescuento = float.Parse(descuentoTb.Text);

                    if (montoDescuento == 0 || montoDescuento > clienteSeleccionado.getPlanAsociado().getCuota()) 
                    {
                        MessageBox.Show("El monto ingresado no es valido.");
                        errores = true;
                    }

                    descuento = true;
                    //Una vez corroborado que el interior del descuento no está vacío y es válido para convertir a float, se crea el descuento.

        

                }
                else // En el caso de que lo ingresado no pueda ser pasado a float
                {
                    MessageBox.Show("Descuento no valido (Caracter invalido)");
                    errores = true;
                    ; // Retorna si el texto no se puede convertir a float                

                }

            }

            

            //Se corrobora que el monto sea correcto

            if (string.IsNullOrWhiteSpace(montoTb.Text)) 
            {
                MessageBox.Show("Ingrese un monto");
                errores = true;
            }   
            else if (!float.TryParse(montoTb.Text, out _))
            {
                MessageBox.Show("Ingrese un monto valido.");
                errores = true;
            }
            else
            {
                //Y se guarda en la variable
                montoPago = int.Parse(montoTb.Text);
            }


            if (mediopago == 4)
            {
                MessageBox.Show("Seleccione un metodo de pago valido");
                errores = true;

            }
            if (errores == false)  //En caso de q no haya ningun error
            {
                //Finalmente se crea y guarda el pago con su descuento.
                TipoMovmiento tipoMovimientoPago = gestorTipoMovmientos.validarExistenciaTipoMov("Pago de cuota", true);

                Pago pagoDeCuotaMov = new Pago(clienteSeleccionado.getCuenta(), dbHelper.GetLastId("movimientos", "idmovimientos"), montoPago
                    , tipoMovimientoPago, mediopago);
                //Finalmente se guarda el movimiento y el descuento.
                //
                gestorMovimientos.addMovmiento(pagoDeCuotaMov);
                dbHelper.insertarMovmiento(pagoDeCuotaMov);


                if (descuento == true)
                {
                    TipoMovmiento tipoMovimientoDescuento = gestorTipoMovmientos.validarExistenciaTipoMov("Descuento", true);

                    int idDescuento = dbHelper.GetLastId("movimientos", "idmovimientos");

                    movmientoDescuento = new Movimiento(clienteSeleccionado.getCuenta(), idDescuento, montoDescuento, tipoMovimientoDescuento);

                    gestorMovimientos.addMovmiento(movmientoDescuento);
                    dbHelper.insertarMovmiento(movmientoDescuento);

                    MessageBox.Show("Pago y descuento resgistrado");

                    this.Close();


                }
                else 
                {
                    MessageBox.Show("Pago registrado."); 
                }


                this.Close();

            }
            else 
            {
                return;
            }



        }

        private void generarPago_Load(object sender, EventArgs e)
        {

        }
    }
}
