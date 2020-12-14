namespace Sistema.Forms
{
    partial class Estoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selecionar = new System.Windows.Forms.Button();
            this.obs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cadastrar = new System.Windows.Forms.Button();
            this.produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.selecionar);
            this.panel1.Controls.Add(this.obs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.qtd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.salvar);
            this.panel1.Controls.Add(this.apagar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.grid);
            this.panel1.Controls.Add(this.cadastrar);
            this.panel1.Controls.Add(this.produto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 390);
            this.panel1.TabIndex = 105;
            // 
            // selecionar
            // 
            this.selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selecionar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionar.Location = new System.Drawing.Point(495, 247);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(75, 23);
            this.selecionar.TabIndex = 117;
            this.selecionar.Text = "Selecionar";
            this.selecionar.UseVisualStyleBackColor = true;
            // 
            // obs
            // 
            this.obs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.obs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.obs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.obs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obs.Location = new System.Drawing.Point(401, 270);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(452, 22);
            this.obs.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Observação";
            // 
            // qtd
            // 
            this.qtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.qtd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.qtd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.qtd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(775, 247);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(78, 22);
            this.qtd.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Quantidade";
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelar.Location = new System.Drawing.Point(765, 350);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 30);
            this.cancelar.TabIndex = 112;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Visible = false;
            // 
            // salvar
            // 
            this.salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.ForeColor = System.Drawing.SystemColors.Window;
            this.salvar.Location = new System.Drawing.Point(671, 350);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(88, 30);
            this.salvar.TabIndex = 111;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = false;
            this.salvar.Visible = false;
            // 
            // apagar
            // 
            this.apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apagar.BackColor = System.Drawing.Color.Red;
            this.apagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.SystemColors.Window;
            this.apagar.Location = new System.Drawing.Point(204, 350);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(94, 30);
            this.apagar.TabIndex = 110;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.SystemColors.Window;
            this.editar.Location = new System.Drawing.Point(104, 350);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(94, 30);
            this.editar.TabIndex = 109;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowEditingIcon = false;
            this.grid.Size = new System.Drawing.Size(857, 241);
            this.grid.TabIndex = 108;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cadastrar.BackColor = System.Drawing.SystemColors.GrayText;
            this.cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.cadastrar.Location = new System.Drawing.Point(3, 350);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(95, 30);
            this.cadastrar.TabIndex = 107;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            // 
            // produto
            // 
            this.produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.produto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.produto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.produto.Enabled = false;
            this.produto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.Location = new System.Drawing.Point(52, 247);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(437, 22);
            this.produto.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Produto";
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.AutoSize = true;
            this.fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecha.Location = new System.Drawing.Point(831, -1);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(26, 25);
            this.fecha.TabIndex = 106;
            this.fecha.Text = "X";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(856, 432);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.TextBox obs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fecha;
    }
}