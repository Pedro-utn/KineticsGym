using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototipoGym.Clases;
using PrototipoGym.DataBase;
using PrototipoGym.GestoresDeClase;
using PrototipoGym.Pantallas.Informes;
using PrototipoGym.Pantallas.Planes;
using PrototipoGym.Reportes;
using PrototipoGym.Reportes.CajaDiaria;
using PrototipoGym.Reportes.ClientesActivos;
using PrototipoGym.Reportes.ResumenSaldos;

namespace PrototipoGym.Pantallas
{
    public partial class SelectorDeInformes : Form

    {
        DatabaseHelper dbHelper;
        gestorCuenta cuentas;
        gestorCliente clientes;
        gestorMovimientos movimientos;
        Cliente clienteSeleccionado;
        DateTime desdeFecha;
        DateTime hastaFecha;


        public SelectorDeInformes(DatabaseHelper dataBase, gestorCuenta cuentas,gestorCliente clientes,gestorMovimientos movimientos)
        {
            this.dbHelper = dataBase; 
            this.cuentas = cuentas;
            this.clientes = clientes;
            this.movimientos = movimientos;
            InitializeComponent();
            nombreTb.ReadOnly = true;
            nombreTb.BackColor = Color.LightGray;
            datetimeCondig();
        }
        private void datetimeCondig() 
        {
            mesDtp.Format = DateTimePickerFormat.Custom;
            mesDtp.CustomFormat = " MM / yy";
            mesDtp.ShowUpDown = true;
        }


        
        //Si se pulsa el checkbox se muestra el menu del filtro desde/hasta.
        private void desdeHastaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (mesDtp.Visible || diaDtp.Visible)
            {
                mesDtp.Visible = false;
                mesLb.Visible = false;
                diaDtp.Visible = false;
                diaLb.Visible = false;
            }   
            

            desdeDtp.Visible = true;
            desdeLb.Visible = true;
            hastaDtp.Visible = true;
            hastaLb.Visible = true;
            
        }

        private void mesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (desdeDtp.Visible  || diaDtp.Visible)
            {
                desdeDtp.Visible = false;
                desdeLb.Visible = false;
                hastaLb.Visible = false;
                hastaDtp.Visible = false;
                diaDtp.Visible = false;
                diaLb.Visible = false;
            }
            mesLb.Visible = true;
            mesDtp.Visible = true;
        }

        private void diaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (mesDtp.Visible || desdeDtp.Visible)
            {
                desdeDtp.Visible = false;
                desdeLb.Visible = false;
                hastaLb.Visible = false;
                hastaDtp.Visible = false;
                mesDtp.Visible = false;
                mesLb.Visible = false;
            }
            diaLb.Visible = true;
            diaDtp.Visible = true;
        }

        private void diaDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            iniciarVisor();

        }
        public void iniciarVisor() 
        {
            if (resumenCuentaCb.Checked)
            {
                //Obtener la fecha correspondiente segun el filtro seleccionado.
                if (desdeHastaCb.Checked)
                {
                    desdeFecha = desdeDtp.Value.Date;
                    hastaFecha = hastaDtp.Value.Date;
                }
                else if (mesCb.Checked)
                {
                    desdeFecha = new DateTime(mesDtp.Value.Year, mesDtp.Value.Month, 1);
                    hastaFecha = desdeFecha.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

    


                }
                else if (diaCb.Checked)
                {
                    desdeFecha = diaDtp.Value.Date;
                    hastaFecha = desdeFecha;


                }
                else { MessageBox.Show("Falta seleccionar un rango de fechas."); }


                //Se crean los recursos necesarios para el visor del repor  te.
                float saldoAnterior = clienteSeleccionado.getCuenta().getSaldoAnterior(desdeFecha);
                DataTable table = dbHelper.generateResumenCuentaDt(clienteSeleccionado.getCuenta().getIdCuenta(), desdeFecha, hastaFecha,saldoAnterior);
                string datosCliente = $"Nro: {clienteSeleccionado.getId()}   Nombre: {clienteSeleccionado.getNombre()}   Tel: {clienteSeleccionado.getTelefono()}";

                visorResumenCuentaForm visorResumenCuenta = new visorResumenCuentaForm(table, saldoAnterior, datosCliente);
                visorResumenCuenta.ShowDialog();

            }
            else if (saldosClientesCb.Checked)
            {
            
                DateTime fecha = diaDtp.Value;
                DataTable tableSaldos = dbHelper.crearSaldoClienteTable(fecha);


                visorSaldos visorSaldos = new visorSaldos(tableSaldos,fecha);
                if (tableSaldos == null || tableSaldos.Rows.Count == 0)
                {
                    MessageBox.Show("La tabla de saldos está vacía.");
                    return;
                }
                visorSaldos.ShowDialog();
            }
            else if (clientesActivosCb.Checked)
            {
                
                DataTable table = dbHelper.crearClientesActivosTable(clientes);
                //Instanciar un visor

                VisorClientesActivos clientesActivosForm = new VisorClientesActivos(table);
                clientesActivosForm.ShowDialog();
            }
            else if (cajaDiariaCb.Checked) 
            {
                // Obtener la fecha correspondiente segun el filtro seleccionado.
                if (desdeHastaCb.Checked)
                {
                    desdeFecha = desdeDtp.Value.Date;
                    hastaFecha = hastaDtp.Value.Date;
                }
                else if (mesCb.Checked)
                {
                    desdeFecha = new DateTime(mesDtp.Value.Year, mesDtp.Value.Month, 1);
                    hastaFecha = desdeFecha.AddMonths(1).AddDays(-1).Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                }
                else if (diaCb.Checked)
                {
                    desdeFecha = diaDtp.Value.Date;
                    hastaFecha = desdeFecha;


                }
                else
                {
                    MessageBox.Show("Falta seleccionar un rango de fechas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // Finalemente se cra la tabla
                float efectivoTotal = movimientos.getEfectivoTotal(desdeFecha, hastaFecha);
                float transferenciaTotal = movimientos.getTransferenciaTotal(desdeFecha, hastaFecha);
                string periodo = $"{desdeFecha.ToString("d")}  -  {hastaFecha.ToString("d")}";

                DataTable table = dbHelper.generateTablaCajaDiaria(movimientos,desdeFecha,hastaFecha);

                CajaDiariaVisor visorcajaDiaria = new CajaDiariaVisor(table,efectivoTotal,transferenciaTotal,periodo);

                visorcajaDiaria.Show();
            }

        }
        private void seleccionarClienteBtn_Click(object sender, EventArgs e)
        {
            BuscarCliente formBuscarCliente = new BuscarCliente(clientes);
            formBuscarCliente.FormClosed += formBuscarCliente_FormClosed;
            formBuscarCliente.Show();

        }
        private void formBuscarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formBuscarCliente = sender as BuscarCliente;

            if (formBuscarCliente != null && formBuscarCliente.getClienteSeleccionado() != null)
            {
                clienteSeleccionado = formBuscarCliente.getClienteSeleccionado();
                nombreTb.Text = clienteSeleccionado.getNombre();
            }
            else
            {
                MessageBox.Show("Formulario cerrado sin selección.");
            }
        }

        private void resumenCuentaCb_CheckedChanged(object sender, EventArgs e)
        {
            seleccionarClienteBtn.Visible = true;
            nombreTb.Visible = true;
            clienteLb.Visible = true;
            mesCb.Visible = true;
            desdeHastaCb.Visible = true;
            diaCb.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ocultarFiltros();
            diaDtp.Visible = true;
            diaCb.Checked = true;
        }

        private void clientesActivosCb_CheckedChanged(object sender, EventArgs e)
        {
            ocultarFiltros();
        }
        private void ocultarFiltros()
        {
            desdeDtp.Visible = false;
            hastaDtp.Visible = false;
            desdeHastaCb.Visible = false;
            mesCb.Visible = false;
            diaCb.Visible = false;
            mesDtp.Visible = false;
            clienteLb.Visible = false; 
            nombreTb.Visible =false;
            seleccionarClienteBtn.Visible=false;
            desdeLb.Visible = false;
            hastaLb.Visible = false;
            diaCb.Checked = false;

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void cajaDiariaCb_CheckedChanged(object sender, EventArgs e)
        {
            ocultarFiltros();
        
            desdeHastaCb.Visible = true;
            mesCb.Visible = true;
            diaCb.Visible = true;
          


        }

        private void SelectorDeInformes_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hastaLb_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
