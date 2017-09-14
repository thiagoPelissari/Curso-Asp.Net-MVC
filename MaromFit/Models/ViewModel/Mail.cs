using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaromFit.Models.ViewModel
{
    public class Mail
    {
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [MaxLength(70)]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        [Display(Name = "Email")]
        public string UserMail { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Assunto")]
        public string Subject { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Mensagem")]
        public string Message { get; set; }
    }
}