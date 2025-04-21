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

namespace PrototipoGym.Reportes.ResumenSaldos
{
    public partial class visorSaldos : Form
    {
        private DataTable saldosTable;
        private DateTime fecha;
        public visorSaldos(DataTable saldos, DateTime fecha)
        {
            InitializeComponent();
            this.saldosTable = saldos;
            this.fecha = fecha;
        }

        private void visorSaldos_Load(object sender, EventArgs e)
        {
            tableSaldosConfig();
            fechaCondig();


            this.reportViewer1.RefreshReport();

        }
        private void tableSaldosConfig() 
        {
            string relativePath = @"Reportes\ResumenSaldos\SaldosClientes.rdlc";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            reportViewer1.LocalReport.ReportPath = absolutePath; ReportDataSource rds = new ReportDataSource("Saldos", saldosTable);

            // Limpiar y asignar los datos al ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
        }

        private void fechaCondig() 
        {
            string relativePath = @"Reportes\ResumenSaldos\SaldosClientes.rdlc";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            reportViewer1.LocalReport.ReportPath = absolutePath;
            Microsoft.Reporting.WinForms.ReportParameter parametro =
            new Microsoft.Reporting.WinForms.ReportParameter("Fecha", fecha.ToShortDateString());
            reportViewer1.LocalReport.SetParameters(new[] { parametro });
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
