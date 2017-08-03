using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaromFit.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display( Name="Nome")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Required]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Data de inscrição")]
        public DateTime SubscribeDate { get; set; }

        public bool IsSubscribedToNews { get; set; }

        public Plan Plan { get; set; }
        public int PlanId { get; set; }
    }
}