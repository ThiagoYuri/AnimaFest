using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Alocacao 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [Required, MinLength(2), MaxLength(200)]
        public string NomeCliente { get; set; }
        [Required]
        public float ValorTotalAlugado { get; set; }
        [Required]
        public DateTime DataInicialAlugada { get; set; }
        [Required]
        public DateTime DataFinalAlugada { get; set; }
        [Required]
        public float PagoEmGasolina { get; set; }
        [Required, MinLength(2), MaxLength(200)]
        public float QuantKMRodado { get; set; }
        [Required]
        public Cidade CidadeAlugada { get; set; }
        [Required]
        public List<Produto> Produtos { get; private set; }
        [Required]
        public List<Gasto> GastosAlocacao { get; set; }

        //Set of product
        public void setProduto(Produto produto)
        {
            if(produto.Alugavel == true)
            {
                this.Produtos.Add(produto);
            }
            else
            {
                throw new Exception("Erro: O Produto precisa ser Alugavel");
            }
        }

    }
}
