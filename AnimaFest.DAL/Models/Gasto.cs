﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaFest.DAL.Models
{
    public class Gasto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(200)]       
        public float ValorGastado { get; set; }

        [Required]
        public TipoGasto TipoGasto { get; set; }
    }
}