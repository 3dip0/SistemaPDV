namespace Sistema
{
    partial class Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fecha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gerarEtiqueta = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cadastrar = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.AutoSize = true;
            this.fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecha.Location = new System.Drawing.Point(1018, 1);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(26, 25);
            this.fecha.TabIndex = 81;
            this.fecha.Text = "X";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gerarEtiqueta);
            this.panel1.Controls.Add(this.categoria);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.salvar);
            this.panel1.Controls.Add(this.apagar);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.grid);
            this.panel1.Controls.Add(this.cadastrar);
            this.panel1.Controls.Add(this.valor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.descricao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 506);
            this.panel1.TabIndex = 82;
            // 
            // gerarEtiqueta
            // 
            this.gerarEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gerarEtiqueta.BackColor = System.Drawing.SystemColors.GrayText;
            this.gerarEtiqueta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.gerarEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerarEtiqueta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarEtiqueta.ForeColor = System.Drawing.SystemColors.Window;
            this.gerarEtiqueta.Location = new System.Drawing.Point(302, 475);
            this.gerarEtiqueta.Name = "gerarEtiqueta";
            this.gerarEtiqueta.Size = new System.Drawing.Size(110, 30);
            this.gerarEtiqueta.TabIndex = 95;
            this.gerarEtiqueta.Text = "Gerar Etiqueta";
            this.gerarEtiqueta.UseVisualStyleBackColor = false;
            // 
            // categoria
            // 
            this.categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.categoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(856, 421);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(182, 25);
            this.categoria.TabIndex = 94;
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.BackColor = System.Drawing.Color.Red;
            this.cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelar.Location = new System.Drawing.Point(950, 475);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 30);
            this.cancelar.TabIndex = 93;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Visible = false;
            // 
            // salvar
            // 
            this.salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.ForeColor = System.Drawing.SystemColors.Window;
            this.salvar.Location = new System.Drawing.Point(856, 475);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(88, 30);
            this.salvar.TabIndex = 92;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = false;
            this.salvar.Visible = false;
            // 
            // apagar
            // 
            this.apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apagar.BackColor = System.Drawing.Color.Red;
            this.apagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.SystemColors.Window;
            this.apagar.Location = new System.Drawing.Point(202, 475);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(94, 30);
            this.apagar.TabIndex = 91;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = false;
            // 
            // editar
            // 
            this.editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.SystemColors.Window;
            this.editar.Location = new System.Drawing.Point(102, 475);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(94, 30);
            this.editar.TabIndex = 90;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(1, 2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid.RowHeadersVisible = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1045, 415);
            this.grid.TabIndex = 89;
            this.grid.TabStop = false;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cadastrar.BackColor = System.Drawing.SystemColors.GrayText;
            this.cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.cadastrar.Location = new System.Drawing.Point(1, 475);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(95, 30);
            this.cadastrar.TabIndex = 88;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            // 
            // valor
            // 
            this.valor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(856, 447);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(181, 25);
            this.valor.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(810, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(783, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Categoria";
            // 
            // tipo
            // 
            this.tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(617, 422);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(160, 25);
            this.tipo.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Tipo";
            // 
            // descricao
            // 
            this.descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(75, 422);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(494, 25);
            this.descricao.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Descrição";
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button gerarEtiqueta;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label1;
    }
}