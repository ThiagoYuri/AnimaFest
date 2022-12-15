using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Alocacao 
    {
        public int Id { get; set; }
        public float ValorTotalAlugado { get; set; }
        public DateTime DataAlugada { get; set; }
        public float PagoEmGasolina { get; set; }
        public float QuantKMRodado { get; set; }
        public Cidade CidadeAlugada { get; set; }

    }
}
