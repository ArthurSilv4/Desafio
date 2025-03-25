using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Model
{
    internal class Tarefas
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DataVencimento { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }

        public Tarefas(string name, string prioridade, string dataVencimento)
        {
            Id = Guid.NewGuid();
            Name = name;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Status = "Pendente";
        }

        public void MarcarConcluir()
        {
            Status = "Concluido";
        }
    }
}
