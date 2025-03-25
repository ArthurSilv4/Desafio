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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.dtpTarefa = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnConcluida = new System.Windows.Forms.Button();
            this.ctTarefa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(118, 64);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(100, 20);
            this.txtTarefa.TabIndex = 0;
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(43, 59);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(69, 24);
            this.lblTarefa.TabIndex = 1;
            this.lblTarefa.Text = "Tarefa";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbPrioridade.Location = new System.Drawing.Point(236, 63);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(121, 21);
            this.cbPrioridade.TabIndex = 2;
            // 
            // dtpTarefa
            // 
            this.dtpTarefa.Location = new System.Drawing.Point(383, 63);
            this.dtpTarefa.Name = "dtpTarefa";
            this.dtpTarefa.Size = new System.Drawing.Size(200, 20);
            this.dtpTarefa.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(621, 61);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.Location = new System.Drawing.Point(46, 109);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.Size = new System.Drawing.Size(650, 112);
            this.dgvTarefa.TabIndex = 5;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(189, 243);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(122, 28);
            this.btnGrafico.TabIndex = 6;
            this.btnGrafico.Text = "Gerar Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnConcluida
            // 
            this.btnConcluida.Location = new System.Drawing.Point(46, 243);
            this.btnConcluida.Name = "btnConcluida";
            this.btnConcluida.Size = new System.Drawing.Size(122, 28);
            this.btnConcluida.TabIndex = 7;
            this.btnConcluida.Text = "Concluida";
            this.btnConcluida.UseVisualStyleBackColor = true;
            this.btnConcluida.Click += new System.EventHandler(this.btnConcluida_Click);
            // 
            // ctTarefa
            // 
            chartArea4.Name = "ChartArea1";
            this.ctTarefa.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ctTarefa.Legends.Add(legend4);
            this.ctTarefa.Location = new System.Drawing.Point(46, 293);
            this.ctTarefa.Name = "ctTarefa";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ctTarefa.Series.Add(series4);
            this.ctTarefa.Size = new System.Drawing.Size(300, 196);
            this.ctTarefa.TabIndex = 8;
            this.ctTarefa.Text = "Tarefas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.ctTarefa);
            this.Controls.Add(this.btnConcluida);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.dgvTarefa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtpTarefa);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.txtTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.DateTimePicker dtpTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnConcluida;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctTarefa;
    }
}

