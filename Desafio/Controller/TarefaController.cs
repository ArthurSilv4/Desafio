using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Model ;

namespace Desafio.Controller
{
    internal class TarefaController
    {
        private TarefasModel model = new TarefasModel();

        public string SaveTarefa(string nome, string prioridade, string data)
        {
            if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(prioridade) || string.IsNullOrEmpty(data))
            {
                return "Nome, prioridade e data são obrigatorios";
            }

            Tarefas tarefa = new Tarefas(nome, prioridade, data);
            model.AddTarefa(tarefa);

            return "Produto Salvo";
        }

        public List<Tarefas> ListarTarefas()
        {
            return model.ListaTarefa();
        }

        public void Concluir(string id)
        {
            model.Concluir(id);
        }
    }
}
