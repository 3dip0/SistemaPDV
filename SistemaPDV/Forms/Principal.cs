using Sistema.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            menuVertical.Width = 0;
            painelCadastro.Height = 0;
            painelProdutos.Height = 0;
            painelOperacao.Height = 0;
            painelFinanceiro.Height = 0;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       

            private void Sistema_Load(object sender, EventArgs e)
        {
            DateTime dateTime = System.DateTime.Now;

            labelData.Text = String.Format("{0:D}",dateTime);
        }
        private void AbrirFormPanel(object Formhijo)
        {
            if (this.painelPrincipal.Controls.Count > 0)
                this.painelPrincipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
        
            this.painelPrincipal.Controls.Add(fh);
            this.painelPrincipal.Tag = fh;
            fh.Show();
        }


            private void menu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 0)
            {
                menuVertical.Width = 250;
            }
            else
            {
                menuVertical.Width = 0;
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;

        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cadastros_Click(object sender, EventArgs e)
        {
            if (painelCadastro.Height == 0)
            {
                painelCadastro.Height = 125;
                painelFinanceiro.Height = 0;
                painelProdutos.Height = 0;
                painelOperacao.Height = 0;
                Cadastro.Image = Image.FromFile(Application.StartupPath+"\\Imagens\\cadastroCima.png");
                financeiro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\financeiro.png");
                operacoes.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\operador.png");
                produtos.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\seta.png");
            }
            else
            {
                painelFinanceiro.Height = 0;
                painelOperacao.Height = 0;
                painelProdutos.Height = 0;
                painelCadastro.Height = 0;
                Cadastro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\cadastro.png");
            }
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            if (painelProdutos.Height == 0)
            {
                painelProdutos.Height = 50;
                painelCadastro.Height = 175;
                painelOperacao.Height = 0;
                painelFinanceiro.Height = 0;
                produtos.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\setaCima.png");
            }
            else
            {
                painelProdutos.Height = 0;
                painelCadastro.Height = 125;
                painelFinanceiro.Height = 0;
                painelOperacao.Height = 0;
                produtos.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\seta.png");
            }
        }

        private void cadastroCliente_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Cliente());
        }

        private void cadastroProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Produto());
        }

        private void categoriaProduto_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Categoria_Produto());
        }

        private void ControleEstoque_Click(object sender, EventArgs e)
        {
            
            AbrirFormPanel(new Estoque());
        }

        private void operacoes_Click(object sender, EventArgs e)
        {
            if (painelOperacao.Height == 0)
            {
                painelOperacao.Height = 50;
                painelProdutos.Height = 0;
                painelCadastro.Height = 0;
                painelFinanceiro.Height = 0;
                operacoes.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\operadorCima.png");
                financeiro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\financeiro.png");
                Cadastro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\cadastro.png");
                produtos.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\seta.png");
            }
            else
            {
                painelFinanceiro.Height = 0;
                painelOperacao.Height = 0;
                painelProdutos.Height = 0;
                painelCadastro.Height = 0;
                operacoes.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\operador.png");
            }
        }


        private void financeiro_Click(object sender, EventArgs e)
        {
            if (painelFinanceiro.Height == 0)
            {
                painelFinanceiro.Height = 75;
                painelProdutos.Height = 0;
                painelCadastro.Height = 0;
                painelOperacao.Height = 0;
                financeiro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\financeiroCima.png");
                Cadastro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\cadastro.png");
                operacoes.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\operador.png");
                produtos.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\seta.png");
            }
            else
            {
                painelFinanceiro.Height = 0;
                painelOperacao.Height = 0;
                painelProdutos.Height = 0;
                painelCadastro.Height = 0;
                financeiro.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\financeiro.png");
            }
        }

        private void fornecedores_Click(object sender, EventArgs e)
        {

        }

        private void transportadores_Click(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
