namespace Sistema
{
    partial class Categoria_Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cadastrar = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(435, 322);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 30);
            this.cancelar.TabIndex = 91;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(341, 322);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(88, 30);
            this.salvar.TabIndex = 90;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Visible = false;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(204, 322);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(94, 30);
            this.apagar.TabIndex = 89;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(104, 322);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(94, 30);
            this.editar.TabIndex = 88;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(4, 3);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(519, 241);
            this.grid.TabIndex = 87;
            this.grid.TabStop = false;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(3, 322);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(95, 30);
            this.cadastrar.TabIndex = 86;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(55, 251);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(468, 20);
            this.descricao.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Descrição";
            // 
            // Categoria_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 356);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label1);
            this.Name = "Categoria_Produto";
            this.Text = "Descricao_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label1;
    }
}