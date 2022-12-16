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
        public string NomeCliente { get; set; }
        public float ValorTotalAlugado { get; set; }
        public DateTime DataAlugada { get; set; }
        public float PagoEmGasolina { get; set; }
        public float QuantKMRodado { get; set; }
        public Cidade CidadeAlugada { get; set; }

        public Produto Produto { get; private set; }

        public void setProduto(Produto produto)
        {
            if(produto.Alugavel == true)
            {
                this.Produto = produto;
            }
            else
            {
                throw new Exception("Erro: O Produto precisa ser Alugavel");
            }
        }
    }
}
