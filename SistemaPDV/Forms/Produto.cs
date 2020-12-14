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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using Ean13Barcode2005;
using Sistema.Forms;

namespace Sistema
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            mostraResultados();
           
        }
        
        public string comando = "";
        public string comando2 = "";
        public List<produto> listaClientes = new List<produto>();
        public List<produto> listaClientes2 = new List<produto>();
        public Ean13 ean13 = null;

        
      
        private void cadastrar_Click(object sender, EventArgs e)
        {
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            try
            {
               
                   conexao.Open();
                    int codigoCategoria = Convert.ToInt32(((DataRowView)categoria.SelectedItem)["idCategoria"]);
                    //inserir o produto
                    string sql = $"INSERT INTO Produto VALUES ('','{descricao.Text}','{tipo.Text}','{codigoCategoria}','','{valor.Text}')";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.ExecuteNonQuery();


                    //Selecionar o produto cadastrado e atualizar com o codigo de barras
                    sql = $"SELECT lpad(idProduto, 13, '0') from Produto where descricao LIKE '{descricao.Text}'";
                    cmd = new MySqlCommand(sql, conexao);
                    MySqlDataReader leitor = cmd.ExecuteReader();
                    string codBarra = "";
                    while (leitor.Read())
                    {
                        codBarra = leitor["lpad(idProduto, 13, '0')"].ToString();
                    }
                    conexao.Close();
                    conexao.Open();
                    sql = $"UPDATE Produto SET codBarra = '{codBarra}' where idProduto = {Convert.ToInt32(codBarra.ToString())}";
                    cmd = new MySqlCommand(sql, conexao);
                    cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
                    MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
                mostraResultados();
            }
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
                limparCampos();
            }

        }

        public void PreencheComboBox()
        {
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();

            try
            {
                    conexao.Open();
                    string sql = "select * from Categoria_Produto";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    categoria.DataSource = dt;
                    categoria.ValueMember = "idCategoria";
                    categoria.DisplayMember = "descricao";
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

        private void apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySql instanciaMysql = new MySql();
                MySqlConnection conexao = instanciaMysql.GetConnection();
                try
                {
                        conexao.Open();
                        string sql = "DELETE FROM Produto WHERE idProduto = @param1";
                        MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.Add(new MySqlParameter("@param1", grid.SelectedCells[0].Value.ToString()));
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        mostraResultados();
                        MessageBox.Show("Apagado com Sucesso!");
                    
                }
                catch (Exception erro)
                {
                   MessageBox.Show("Verifique se não contém esse produto em Estoque!/n"+erro);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.descricao.Text = Convert.ToString(this.grid.CurrentRow.Cells["Descrição"].Value);
            this.tipo.Text = Convert.ToString(this.grid.CurrentRow.Cells["Tipo"].Value);
            this.categoria.Text = Convert.ToString(this.grid.CurrentRow.Cells["Categoria"].Value);
            this.valor.Text = Convert.ToString(this.grid.CurrentRow.Cells["Valor"].Value);
         

            this.salvar.Visible = true;
            this.cancelar.Visible = true;
            this.editar.Visible = false;
            this.cadastrar.Visible = false;
            this.apagar.Visible = false;
            this.gerarEtiqueta.Visible = false;

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.cancelar.Visible = false;


            if (MessageBox.Show("Deseja alterar o registro?", "Alteração", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySql instanciaMysql = new MySql();

                try
                {
                    using (MySqlConnection conexao = instanciaMysql.GetConnection())
                    {
                        conexao.Open();
                        int codigoCategoria = Convert.ToInt32(((DataRowView)categoria.SelectedItem)["idCategoria"]);
                        string sql = $"update Produto set descricao='{descricao.Text}',tipoUnitario='{tipo.Text}',idCategoria='{codigoCategoria}',valor='{valor.Text}' WHERE idProduto = @param1";
                        MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.Add(new MySqlParameter("@param1", grid.CurrentRow.Cells[0].Value));
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        mostraResultados();
                        limparCampos();
                        MessageBox.Show("Salvo com Sucesso!");
                        this.editar.Visible = true;
                        this.cadastrar.Visible = true;
                        this.apagar.Visible = true;
                        this.gerarEtiqueta.Visible = true;

                    }

                }
                catch (Exception erro)
                {
                    throw erro;
                }

            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.cancelar.Visible = false;
            this.editar.Visible = true;
            this.cadastrar.Visible = true;
            this.apagar.Visible = true;
            this.gerarEtiqueta.Visible = true;
            limparCampos();
        }

        public void limparCampos()
        {
            this.descricao.Text = "";
            this.tipo.Text = "";
            this.categoria.Text = "";
            this.valor.Text = "";
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            PreencheComboBox();
            grid.BorderStyle = BorderStyle.None;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
           
            grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grid.BackgroundColor = Color.White;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(69, 69, 69);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void gerarEtiqueta_Click(object sender, EventArgs e)
        {
            dados();

            Etiqueta etiqueta = new Etiqueta(comando);
            etiqueta.ShowDialog();
        }

        public class produto
        {
            public string produtoid { get; set; }

            public produto()
            { }

            public produto(string id)
            {
                produtoid = id;

            }
        }
        public void dados()
        {

            string cod;
            
            bool atv = true;

            foreach (DataGridViewRow row in grid.Rows)
            {

                if (row.IsNewRow) continue;
               
                    cod = Convert.ToString(row.Cells[0].Value);
                   

                    if (atv == true)
                    {
                        comando = $" idProduto = '{cod}'";



                        atv = false;
                    }
                    else
                    {
                        comando += $" || idProduto = '{cod}'";

                    }
                
            }

        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
