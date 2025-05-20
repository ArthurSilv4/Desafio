namespace Desafio
{
    partial class Form1
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAdicionarFavorito = new System.Windows.Forms.Button();
            this.btnListarFavorito = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbPrecoMin = new System.Windows.Forms.Label();
            this.lbPrecoMax = new System.Windows.Forms.Label();
            this.btnFiltrarPreco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(412, 301);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Buscar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 254);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtFiltrarCategoria
            // 
            this.txtFiltrarCategoria.Location = new System.Drawing.Point(123, 115);
            this.txtFiltrarCategoria.Name = "txtFiltrarCategoria";
            this.txtFiltrarCategoria.Size = new System.Drawing.Size(125, 20);
            this.txtFiltrarCategoria.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(269, 115);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAdicionarFavorito
            // 
            this.btnAdicionarFavorito.Location = new System.Drawing.Point(46, 198);
            this.btnAdicionarFavorito.Name = "btnAdicionarFavorito";
            this.btnAdicionarFavorito.Size = new System.Drawing.Size(125, 23);
            this.btnAdicionarFavorito.TabIndex = 4;
            this.btnAdicionarFavorito.Text = "Adicionar Favorito";
            this.btnAdicionarFavorito.UseVisualStyleBackColor = true;
            this.btnAdicionarFavorito.Click += new System.EventHandler(this.btnAdicionarFavorito_Click);
            // 
            // btnListarFavorito
            // 
            this.btnListarFavorito.Location = new System.Drawing.Point(46, 238);
            this.btnListarFavorito.Name = "btnListarFavorito";
            this.btnListarFavorito.Size = new System.Drawing.Size(125, 23);
            this.btnListarFavorito.TabIndex = 5;
            this.btnListarFavorito.Text = "Listar Favoritos";
            this.btnListarFavorito.UseVisualStyleBackColor = true;
            this.btnListarFavorito.Click += new System.EventHandler(this.btnListarFavorito_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lbPrecoMin
            // 
            this.lbPrecoMin.AutoSize = true;
            this.lbPrecoMin.Location = new System.Drawing.Point(43, 43);
            this.lbPrecoMin.Name = "lbPrecoMin";
            this.lbPrecoMin.Size = new System.Drawing.Size(71, 13);
            this.lbPrecoMin.TabIndex = 8;
            this.lbPrecoMin.Text = "Preço Minimo";
            // 
            // lbPrecoMax
            // 
            this.lbPrecoMax.AutoSize = true;
            this.lbPrecoMax.Location = new System.Drawing.Point(43, 79);
            this.lbPrecoMax.Name = "lbPrecoMax";
            this.lbPrecoMax.Size = new System.Drawing.Size(74, 13);
            this.lbPrecoMax.TabIndex = 9;
            this.lbPrecoMax.Text = "Preço Maximo";
            // 
            // btnFiltrarPreco
            // 
            this.btnFiltrarPreco.Location = new System.Drawing.Point(269, 31);
            this.btnFiltrarPreco.Name = "btnFiltrarPreco";
            this.btnFiltrarPreco.Size = new System.Drawing.Size(125, 68);
            this.btnFiltrarPreco.TabIndex = 10;
            this.btnFiltrarPreco.Text = "Filtrar";
            this.btnFiltrarPreco.UseVisualStyleBackColor = true;
            this.btnFiltrarPreco.Click += new System.EventHandler(this.btnFiltrarPreco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarPreco);
            this.Controls.Add(this.lbPrecoMax);
            this.Controls.Add(this.lbPrecoMin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListarFavorito);
            this.Controls.Add(this.btnAdicionarFavorito);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltrarCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFiltrarCategoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAdicionarFavorito;
        private System.Windows.Forms.Button btnListarFavorito;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbPrecoMin;
        private System.Windows.Forms.Label lbPrecoMax;
        private System.Windows.Forms.Button btnFiltrarPreco;
        private System.Windows.Forms.Label label1;
    }
}

