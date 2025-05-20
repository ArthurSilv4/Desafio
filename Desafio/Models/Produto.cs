using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    internal class Produto
    {
        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string category { get; set; }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
