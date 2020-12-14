using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            mostraResultados();
        }
      

        private void produto_TextChanged(object sender, EventArgs e)
        {

            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            try
            {
                conexao.Open();
                


                using (DataTable dt = new DataTable())
                {
                    string sql = "select descricao from Produto where descricao LIKE @descricao";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.Add(new MySqlParameter("@descricao", "%" + produto.Text + "%"));
                    MySqlDataReader datareader = cmd.ExecuteReader();
                    dt.Load(datareader);
                    AutoCompleteStringCollection local = new AutoCompleteStringCollection();
                    if (dt.Rows.Count >= 0)
                    {
                        for (int count = 0; count < dt.Rows.Count; count++)
                        {
                            local.Add(dt.Rows[count]["descricao"].ToString());
                        }
                    }
                    conexao.Close();
                    produto.AutoCompleteMode = AutoCompleteMode.Suggest;
                    produto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    produto.AutoCompleteCustomSource = local;
                    
                }
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

        private void cadastrar_Click(object sender, EventArgs e)
        {
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            try
            {
                conexao.Open();
                string sql = $"select idProduto from Produto where descricao LIKE '{produto.Text}'";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataReader leitor = cmd.ExecuteReader();
                int idProduto = 0;
                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //passo os valores para o objeto cliente 
                    //que será retornado 
                    idProduto = Convert.ToInt32(leitor["idProduto"].ToString());

                }
                conexao.Close();
                conexao.Open();
                sql = $"INSERT INTO Estoque VALUES ('','{idProduto}',{qtd.Text},'{obs.Text}')";
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
                string sql = "SELECT Estoque.idEstoque as Código, " +
              "Produto.descricao as Descrição, " +
              "Estoque.quantidade as Quantidade, " +
               "Produto.valor as Valor_Unitário, " +
               "Estoque.quantidade*Produto.valor as Total_em_Estoque, " +
               "Estoque.obs as Observação FROM Produto " +
              "inner join Estoque " +
              "on Produto.idProduto = Estoque.idProduto ";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
           
                //preenche o dataset através do adapter
                da.Fill(ds, "Estoque");

                //atribui o resultado à propriedade DataSource da dataGridView
                grid.DataSource = ds;
                grid.DataMember = "Estoque";
                grid.Columns["Valor_Unitário"].DefaultCellStyle.Format = "c2";
                grid.Columns["Total_em_Estoque"].DefaultCellStyle.Format = "c2";

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
                    string sql = "DELETE FROM Estoque WHERE idEstoque = @param1";
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
                    MessageBox.Show("Verifique se não contém esse produto em Estoque!/n" + erro);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.produto.Text = Convert.ToString(this.grid.CurrentRow.Cells["Descrição"].Value);
            this.qtd.Text = Convert.ToString(this.grid.CurrentRow.Cells["Quantidade"].Value);
            this.obs.Text = Convert.ToString(this.grid.CurrentRow.Cells["Observação"].Value);
          


            this.salvar.Visible = true;
            this.cancelar.Visible = true;
            this.editar.Visible = false;
            this.cadastrar.Visible = false;
            this.apagar.Visible = false;
        }

        private void selecionar_Click(object sender, EventArgs e)
        {
            SelecionarProduto selecionar = new SelecionarProduto();
            selecionar.ShowDialog();
            produto.Text = selecionar.nomeProduto;
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.cancelar.Visible = false;
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            if (MessageBox.Show("Deseja alterar o registro?", "Alteração", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    string sql = $"update Estoque set " +
                        $"quantidade='{qtd.Text}', obs='{obs.Text}' " +
                        $"WHERE idEstoque = @param1";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.Add(new MySqlParameter("@param1", grid.CurrentRow.Cells[0].Value));
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    throw erro;
                }
                finally
                {
                    conexao.Close();
                    mostraResultados();
                    limparCampos();
                    MessageBox.Show("Salvo com Sucesso!");
                    this.editar.Visible = true;
                    this.cadastrar.Visible = true;
                    this.apagar.Visible = true;
                }

            }
            
        }


        public void limparCampos()
        {
            this.produto.Text = "";
            this.qtd.Text = "";
            this.obs.Text = "";
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.cancelar.Visible = false;
            this.editar.Visible = true;
            this.cadastrar.Visible = true;
            this.apagar.Visible = true;
            limparCampos();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
