using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Model;

namespace Desafio.Model
{
    internal class TarefasModel
    {
        private static List<Tarefas> tarefas = new List<Tarefas>();

        public void AddTarefa(Tarefas tarefa)
        {
            tarefas.Add(tarefa);
        }

        public List<Tarefas> ListaTarefa()
        {
            return tarefas;
        }

        public void Concluir(string id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id.ToString() == id);
            if (tarefa != null)
            {
                tarefa.MarcarConcluir();
            }
        }
    }
}
