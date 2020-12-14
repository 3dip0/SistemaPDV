using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms
{
    public partial class SelecionarProduto : Form
    {
        public SelecionarProduto()
        {
            InitializeComponent();
           
        }

        private void SelecionarProduto_Load(object sender, EventArgs e)
        {
            mostraResultados();
        }
        private void mostraResultados()
        {
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            try
            {
                conexao.Open();
                string sql = "SELECT Produto.idProduto as Código, " +
          "Produto.descricao as Descrição, " +
          "Produto.tipoUnitario as Tipo, " +
          "Categoria_Produto.descricao as Categoria, " +
          "Produto.codBarra as Código_de_Barras, " +
          "Produto.valor as Valor FROM Produto " +
          "inner join Categoria_Produto " +
          "on Produto.idCategoria = Categoria_Produto.idCategoria ORDER BY idProduto";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                //preenche o dataset através do adapter
                da.Fill(ds, "Produto");
                //atribui o resultado à propriedade DataSource da dataGridView
                grid.DataSource = ds;
                grid.DataMember = "Produto";
                grid.Columns["Valor"].DefaultCellStyle.Format = "c2";
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
               
            }

        }
       public string nomeProduto;
        private void button1_Click(object sender, EventArgs e)
        {
            nomeProduto = Convert.ToString(this.grid.CurrentRow.Cells["Descrição"].Value);
            Estoque produto = new Estoque();
            Close();
        }
    }
}
