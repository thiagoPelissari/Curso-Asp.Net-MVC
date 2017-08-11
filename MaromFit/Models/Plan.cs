using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaromFit.Models
{
    public class Plan
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public float Value { get; set; }

        public static readonly byte Desconhecido = 0;
        public static readonly byte PlanoLivre = 4;
    }
}