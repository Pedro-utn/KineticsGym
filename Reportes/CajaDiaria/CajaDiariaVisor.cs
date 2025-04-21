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
using PrototipoGym.Clases;

namespace PrototipoGym.Reportes.CajaDiaria
{
    public partial class CajaDiariaVisor : Form
    {
        private DataTable table;
        private float transferenciaTotal;
        private float efectivoTotal;
        private string periodo;
        public CajaDiariaVisor(DataTable table, float efectivoTotal, float transferenciaTotal, string periodo)
        {
            InitializeComponent();
            this.table = table;
            this.efectivoTotal = efectivoTotal;
            this.transferenciaTotal = transferenciaTotal;
            this.periodo = periodo;
        }

        private void CajaDiariaVisor_Load(object sender, EventArgs e)
        {
            configTable();
            configParameterTotal();
            this.reportViewer1.RefreshReport();

        }

        private void configTable()
        {
            string relativePath = @"Reportes\CajaDiaria\CaJaDiaria.rdlc";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            reportViewer1.LocalReport.ReportPath = absolutePath;

            ReportDataSource rds = new ReportDataSource("CajasDiarias", table);

            // Limpiar y asignar los datos al ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
        }
        private void configParameterTotal()
        {
            string relativePath = @"Reportes\CajaDiaria\CaJaDiaria.rdlc";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            reportViewer1.LocalReport.ReportPath = absolutePath;

            // Declarar y asignar ambos parámetros
            Microsoft.Reporting.WinForms.ReportParameter efectivoParametro =
                new Microsoft.Reporting.WinForms.ReportParameter("efectivoTotal", $"{efectivoTotal}");
            Microsoft.Reporting.WinForms.ReportParameter transferenciaParametro =
                new Microsoft.Reporting.WinForms.ReportParameter("transferenciaTotal", $"{transferenciaTotal}");
            Microsoft.Reporting.WinForms.ReportParameter periodoP =
                new Microsoft.Reporting.WinForms.ReportParameter("periodo",$"{periodo}");

            // Configurar ambos parámetros en el reporte
            reportViewer1.LocalReport.SetParameters(new[] { efectivoParametro, transferenciaParametro,periodoP });
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
