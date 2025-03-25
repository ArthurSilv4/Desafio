using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Desafio.Controller;
using Desafio.Model;

namespace Desafio
{
    public partial class Form1 : Form
    {
        private TarefaController controller = new TarefaController();
        int media = 0;

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrafico();
        }

        private void ConfigurarGrafico()
        {
            ctTarefa.Series.Clear();
            ctTarefa.Series.Add("Tarefas");
            ctTarefa.Series["Tarefas"].ChartType = SeriesChartType.Column;
            ctTarefa.Series["Tarefas"].IsValueShownAsLabel = true;
            ctTarefa.ChartAreas[0].AxisX.Title = "Status";
            ctTarefa.ChartAreas[0].AxisY.Title = "Quantidades tarefas";
            ctTarefa.ChartAreas[0].AxisX.Interval = 1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string name = txtTarefa.Text;
            string prioridade = cbPrioridade.Text;
            string data = dtpTarefa.Text;
            
            string msg = controller.SaveTarefa(name, prioridade, data);
            MessageBox.Show(msg);
            this.RecarregarDGV();
        }

        private void RecarregarDGV()
        {
            List<Tarefas> tarefas = controller.ListarTarefas();

            dgvTarefa.DataSource = null;
            dgvTarefa.DataSource = tarefas;
        }

        private void btnConcluida_Click(object sender, EventArgs e)
        {
            string celula = dgvTarefa.SelectedRows[0].Cells[0].Value.ToString();

            controller.Concluir(celula);
            this.RecarregarDGV();

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            AtualizarGrafico();
        }

        private void AtualizarGrafico()
        {
            ctTarefa.Series["Tarefas"].Points.Clear();

            foreach (var tarefa in controller.ListarTarefas())
            {
                

                if (tarefa.Name.Equals("Média"))
                {
                    media++;
                }

           

                ctTarefa.Series["Tarefas"].Points.AddXY(tarefa.Prioridade, media);
            }
        }
    }
}
