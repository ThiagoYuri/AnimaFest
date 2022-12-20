using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Gasolina
    {
        [Key]
        public DateTime DataInsercao { get; set; }

        [Required]
        public float PrecoPorLitro { get; set; }
    }
}
