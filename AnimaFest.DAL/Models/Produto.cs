using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Produto
    {        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(200)]
        public string Nome { get; set; }
        public string Descricao { get; set; }       
        public float ?PrecoMedioAluguel { get; set; }
        [Required]
        public bool Alugavel { get; set; }

        public List<Gasto> GastosProduto { get; set; }
    }
}
