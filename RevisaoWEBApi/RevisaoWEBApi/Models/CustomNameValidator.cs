using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null) //fazendo a primeira validação (para nome)
            {
                if(value.ToString().Contains("Teste"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Não deu certo");
                }
            }

            return new ValidationResult("O campo: " + validationContext.DisplayName + " é um campo obrigatório");
        }
    }
}