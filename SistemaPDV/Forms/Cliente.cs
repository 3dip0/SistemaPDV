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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
         
            mostraResultados();
       

        }



        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        String connString = "server = sql247.main-hosting.eu; " +
                "database=u917973598_bd_cda;" +
                "uid=u917973598_admin;" +
                "pwd=admin";


        private void cadastrar_Click(object sender, EventArgs e)
        {

            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();



            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Cliente VALUES ('','{nome.Text}','{cnpj.Text}','{inscricao.Text}',{cep.Text},'{end.Text}',{numero.Text},'{bairro.Text}','{contato1.Text}','{contato2.Text}','{obs.Text}')";
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
                mostraResultados();
            }
        }

        private void mostraResultados()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(connString);
            mConn.Open();

            //cria um adapter utilizando a instrução SQL para aceder à tabela
            mAdapter = new MySqlDataAdapter("SELECT * FROM Cliente ORDER BY idCliente", mConn);

            //preenche o dataset através do adapter
            mAdapter.Fill(mDataSet, "Cliente");
            
            //atribui o resultado à propriedade DataSource da dataGridView
            grid.DataSource = mDataSet;
            grid.DataMember = "Cliente";
            grid.Columns[0].HeaderText = "Código";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CNPJ ou CPF";
            grid.Columns[3].HeaderText = "Inscrição ou RG";
            grid.Columns[4].HeaderText = "CEP";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "nº";
            grid.Columns[7].HeaderText = "Bairro";
            grid.Columns[8].HeaderText = "Contato 1";
            grid.Columns[9].HeaderText = "Contato 2";
            grid.Columns[10].HeaderText = "Observação";
          

            limparCampos();

        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                string sql = "DELETE FROM Cliente WHERE idCliente = @param1";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add(new MySqlParameter("@param1", grid.CurrentCell.Value));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                mostraResultados();
                MessageBox.Show("Apagado com Sucesso!");
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.nome.Text = Convert.ToString(this.grid.CurrentRow.Cells["Nome"].Value);
            this.cnpj.Text = Convert.ToString(this.grid.CurrentRow.Cells["cnpj_cpf"].Value);
            this.inscricao.Text = Convert.ToString(this.grid.CurrentRow.Cells["Inscricao_rg"].Value);
            this.cep.Text = Convert.ToString(this.grid.CurrentRow.Cells["CEP"].Value);
            this.end.Text = Convert.ToString(this.grid.CurrentRow.Cells["End"].Value);
            this.numero.Text = Convert.ToString(this.grid.CurrentRow.Cells["Numero"].Value);
            this.bairro.Text = Convert.ToString(this.grid.CurrentRow.Cells["bairro"].Value);
            this.contato1.Text = Convert.ToString(this.grid.CurrentRow.Cells["contato"].Value);
            this.contato2.Text = Convert.ToString(this.grid.CurrentRow.Cells["contato2"].Value);
            this.obs.Text = Convert.ToString(this.grid.CurrentRow.Cells["Observacao"].Value);

            this.salvar.Visible = true;
            this.fechar.Visible = true;
            this.editar.Visible = false;
            this.cadastrar.Visible = false;
            this.apagar.Visible = false;

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.fechar.Visible = false;
           

            if (MessageBox.Show("Deseja alterar o registro?", "Alteração", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                string sql = $"update Cliente set Nome='{nome.Text}',cnpj_cpf='{cnpj.Text}',Inscricao_rg='{inscricao.Text}',CEP={cep.Text},End='{end.Text}',Numero={numero.Text},bairro='{bairro.Text}',contato='{contato1.Text}',contato2='{contato2.Text}',Observacao='{obs.Text}' WHERE idCliente = @param1";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.Add(new MySqlParameter("@param1", grid.CurrentRow.Cells[0].Value));
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                mostraResultados();
            }
            limparCampos();
            MessageBox.Show("Salvo com Sucesso!");
            this.editar.Visible = true;
            this.cadastrar.Visible = true;
            this.apagar.Visible = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.salvar.Visible = false;
            this.fechar.Visible = false;
            this.editar.Visible = true;
            this.cadastrar.Visible = true;
            this.apagar.Visible = true;
            limparCampos();
        }

        public void limparCampos()
        {
            this.nome.Text = "";
            this.cnpj.Text = "";
            this.inscricao.Text = "";
            this.cep.Text = "";
            this.end.Text = "";
            this.numero.Text = "";
            this.bairro.Text = "";
            this.contato1.Text = "";
            this.contato2.Text = "";
            this.obs.Text = "";
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
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

        private void fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
