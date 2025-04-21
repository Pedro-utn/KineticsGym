using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PrototipoGym.Reportes
{
    public partial class visorResumenCuentaForm : Form
    {
        DataTable table;
        private float saldoAnterior;
        private string datosCliente;
        public visorResumenCuentaForm(DataTable table, float saldoAnterior, string datosCliente)
        {
            InitializeComponent();
            this.table = table;
            this.saldoAnterior = saldoAnterior;
            this.datosCliente = datosCliente;
        }

        private void visorResumenCuentaForm_Load(object sender, EventArgs e)            
        {
            string rutaTxt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes" , "ResumenCuenta.rdlc");

            //Se configuro el table de los movimientos y los parametros.
            saldoAnteioriroParameterConfig(rutaTxt);
            movimientosTableConfig(rutaTxt);
            datosClienteConfig(rutaTxt);

            // Se actualiza el visor de reporte.
            this.reportViewer1.RefreshReport();
        }

        private void movimientosTableConfig(string path) 
        {
            reportViewer1.LocalReport.ReportPath = path;
            ReportDataSource rds = new ReportDataSource("DataSet1", table);

            // Limpiar y asignar los datos al ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
        }
        private void saldoAnteioriroParameterConfig(string path) 
        {
            reportViewer1.LocalReport.ReportPath = path;

            Microsoft.Reporting.WinForms.ReportParameter parametro =
            new Microsoft.Reporting.WinForms.ReportParameter("saldoAnteriorParameter", saldoAnterior.ToString());

            reportViewer1.LocalReport.SetParameters(new[] { parametro });

        }

        private void datosClienteConfig(string path) 
        {
            reportViewer1.LocalReport.ReportPath = path;

            Microsoft.Reporting.WinForms.ReportParameter parametro =
            new Microsoft.Reporting.WinForms.ReportParameter("datosCliente", datosCliente);

            reportViewer1.LocalReport.SetParameters(new[] { parametro });


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
