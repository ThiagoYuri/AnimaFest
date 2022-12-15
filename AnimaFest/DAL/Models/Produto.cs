using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Produto
    {
        
        private bool Alugavel{ get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public float PrecoMedioAluguel { get; set; }

        public List<Gasto> GastosProduto { get; set; }
    }
}
