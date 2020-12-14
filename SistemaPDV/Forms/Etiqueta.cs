using Ean13Barcode2005;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Forms;
using Microsoft.Reporting.WinForms;

namespace Sistema.Forms
{
    public partial class Etiqueta : Form
    {
        public Etiqueta(string produto)
        {
            InitializeComponent();
            try
            {
                this.etiquetas.LocalReport.EnableExternalImages = true;
                MySqlDataAdapter da;

                bdProdutos bdProduto = new bdProdutos();
                mConn = new MySqlConnection(connString);
                mConn.Open();
                string sql = $"SELECT * from Produto where " + produto;
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                da = new MySqlDataAdapter(cmd);
                da.Fill(bdProduto, bdProduto.Tables[0].TableName);

                ReportDataSource rds = new ReportDataSource("Produtos", bdProduto.Tables[0]);

                this.etiquetas.LocalReport.DataSources.Clear();
                this.etiquetas.LocalReport.DataSources.Add(rds);
                this.etiquetas.LocalReport.Refresh();
                this.etiquetas.SetDisplayMode(DisplayMode.PrintLayout);
                var setup = etiquetas.GetPageSettings();
                setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                etiquetas.SetPageSettings(setup);
                this.etiquetas.RefreshReport();



                MySqlDataReader leitor = cmd.ExecuteReader();

                string codBarra = "";
                while (leitor.Read())
                {

                    codBarra = leitor["codBarra"].ToString();

                }



                ean13 = new Ean13();
                ean13.CountryCode = codBarra;

                ean13.Scale = (float)Convert.ToDecimal(0.5);

                System.Drawing.Bitmap bmp = ean13.CreateBitmap();
                bmp.Save(Application.StartupPath + "\\img.jpg");
                this.etiquetas.LocalReport.EnableExternalImages = true;
                this.etiquetas.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Etiqueta", @"File://" + Application.StartupPath + "\\img.jpg"));

                this.etiquetas.LocalReport.DataSources.Clear();
                this.etiquetas.LocalReport.DataSources.Add(rds);

                this.etiquetas.RefreshReport();
            }
            finally
            {
                mConn.Close();
            }
        }
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        String connString = "server = sql247.main-hosting.eu; " +
                "database=u917973598_bd_cda;" +
                "uid=u917973598_admin;" +
                "pwd=admin";
        private Ean13 ean13 = null;

        private void Etiqueta_Load(object sender, EventArgs e)
        {

        }
    }
}
