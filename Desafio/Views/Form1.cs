using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Desafio.Controllers;
using Desafio.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;

namespace Desafio
{
    public partial class Form1 : Form
    {
        private List<Produto> produtos = new List<Produto>();

        private List<Produto> favoritos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
            Busca();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Busca();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltrarCategoria.Text;

            var produtos = FiltroCategoria(filtro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
        }

        private void btnFiltrarPreco_Click(object sender, EventArgs e)
        {
            float valor1 =  float.Parse(textBox1.Text);
            float valor2 = float.Parse(textBox2.Text);

            var produtos = FiltroPreco(valor1, valor2);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
        }

        private void btnAdicionarFavorito_Click(object sender, EventArgs e)
        {
            var produto = (Produto)dataGridView1.CurrentRow.DataBoundItem;

            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=db_produto;Integrated Security=True;"))
            {
                conn.Open();

                // Verifica se já existe
                var checkCmd = new SqlCommand("SELECT COUNT(*) FROM ListarFavoritos2 WHERE IdProdutoApi = @Id", conn);
                checkCmd.Parameters.AddWithValue("@Id", produto.id);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    var cmd = new SqlCommand("INSERT INTO ListarFavoritos2 (IdProdutoApi, Title, Price, Category) VALUES (@Id, @Title, @Price, @Category)", conn);
                    cmd.Parameters.AddWithValue("@Id", produto.id);
                    cmd.Parameters.AddWithValue("@Title", produto.title);
                    cmd.Parameters.AddWithValue("@Price", produto.price);
                    cmd.Parameters.AddWithValue("@Category", produto.category);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado aos favoritos!");
                }
                else
                {
                    MessageBox.Show("Este produto já está nos favoritos.");
                }

            }
        }

        private void btnListarFavorito_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=db_produto;Integrated Security=True;"))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT IdProdutoApi, Title, Price, Category FROM ListarFavoritos2", conn);
                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private List<Produto> FiltroPreco(float valor1, float valor2)
        {
            var filtrado = produtos.Where(c => c.price >= valor1 && c.price <= valor2).ToList();

            return filtrado;
        }

        private List<Produto> FiltroCategoria(string filtro)
        {
            var filtrado = produtos.Where(c => c.category.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();

            return filtrado;
        }

        private async void Busca()
        {
            string url = "https://fakestoreapi.com/products";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    produtos = JsonSerializer.Deserialize<List<Produto>>(json);

                    dataGridView1.DataSource = produtos;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
