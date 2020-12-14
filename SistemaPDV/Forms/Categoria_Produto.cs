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

namespace Sistema
{
    public partial class Categoria_Produto : Form
    {
        public Categoria_Produto()
        {
            InitializeComponent();
            mostraResultados();

        }
     
        private void cadastrar_Click(object sender, EventArgs e)
        {
            MySql instanciaMysql = new MySql();
            MySqlConnection conexao = instanciaMysql.GetConnection();
            try
            {
                    conexao.Open();
                    string sql = $"INSERT INTO Categoria_Produto VALUES ('','{descricao.Text}')";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
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
                    string sql = "SELECT * FROM Categoria_Produto ORDER BY idCategoria";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
              
                    //preenche o dataset através do adapter
                    da.Fill(ds, "Categoria_Produto");

                    //atribui o resultado à propriedade DataSource da dataGridView
                    grid.DataSource = ds;
                    grid.DataMember = "Categoria_Produto";
                    grid.Columns[0].HeaderText = "Código";
                    grid.Columns[1].HeaderText = "Descrição";
                    limparCampos();
                
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

            MySql instanciaMysql = new MySql(); 
            MySqlConnection conexao = instanciaMysql.GetConnection();

            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                        conexao.Open();
                        string sql = "DELETE FROM Categoria_Produto WHERE idCategoria = @idCategoria";
                        MySqlCommand cmd = new MySqlCommand(sql, conexao);
                                 
                        cmd.Parameters.Add(new MySqlParameter("@idCategoria", grid.SelectedCells[0].Value.ToString()));
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
                    MessageBox.Show("Apagado com Sucesso!");
                }
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.descricao.Text = Convert.ToString(this.grid.CurrentRow.Cells["descricao"].Value);
          


            this.salvar.Visible = true;
            this.cancelar.Visible = true;
            this.editar.Visible = false;
            this.cadastrar.Visible = false;
            this.apagar.Visible = false;

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
                        string sql = $"update Categoria_Produto set descricao='{descricao.Text}' WHERE idCategoria = @param1";

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

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.cancelar.Visible = false;
            this.editar.Visible = true;
            this.cadastrar.Visible = true;
            this.apagar.Visible = true;
            limparCampos();
        }

        public void limparCampos()
        {
            this.descricao.Text = "";
        }

     
    }
}
