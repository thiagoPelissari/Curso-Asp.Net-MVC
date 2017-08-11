using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaromFit.Models
{
    public class Min18YearIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var client = (Client)validationContext.ObjectInstance;

            if (client.PlanId == Plan.Desconhecido || client.PlanId == Plan.PlanoLivre)
                return ValidationResult.Success;

            if (client.BirthDate == null)
                return new ValidationResult("Data de nascimento é obrigatório!");

            var age = DateTime.Today.Year - client.BirthDate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("A idade deve ser maior que 18 anos!");
        }
    }
}