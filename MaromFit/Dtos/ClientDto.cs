using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaromFit.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o nome CORRETOOOO!")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Mail { get; set; }

        [Required]
//      [Min18YearIfMember]
        public DateTime? BirthDate { get; set; }

        public DateTime? SubscribeDate { get; set; }

        public bool IsSubscribedToNews { get; set; }

        public PlanDto Plan { get; set; }

        public int PlanId { get; set; }
    }
}