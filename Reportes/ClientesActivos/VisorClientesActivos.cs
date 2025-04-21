using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PrototipoGym.Reportes.ClientesActivos
{
    public partial class VisorClientesActivos : Form
    {
        private DataTable table;
        public VisorClientesActivos(DataTable table)
        {
            InitializeComponent();
            this.table = table;
        }

        private void VisorClientesActivos_Load(object sender, EventArgs e)
        {
            configTableClientesActivos();
            this.reportViewer1.RefreshReport();
        }
        private void configTableClientesActivos() 
        {
            string relativePath = @"Reportes\ClientesActivos\ClientesActivos.rdlc";
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            reportViewer1.LocalReport.ReportPath = absolutePath;

            ReportDataSource rds = new ReportDataSource("ClientesActivosTabla", table);

            // Limpiar y asignar los datos al ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
