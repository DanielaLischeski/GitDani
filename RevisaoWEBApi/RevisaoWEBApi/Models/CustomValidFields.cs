using RevisaoWEBApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type; // inicializando as variáveis no construtor
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) //já valida para nenhum dos campus ser nulo
            {
                switch (typeField)
                {
                    case ValidFields.ValidaNome: { return ValidarNome(value, validationContext.DisplayName); }
                       
                    case ValidFields.ValidaEmail: {return ValidarEmail(value, validationContext.DisplayName); } //se tem o return não precisa do break                   
                        
                    case ValidFields.ValidaLogin: { return ValidarLogin(value, validationContext.DisplayName); }
                                     
                    case ValidFields.ValidaSenha: { return ValidarSenha(value, validationContext.DisplayName); }     
                        
                    default:
                        break;
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
        }
        private ValidationResult ValidarEmail(object value,string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
          
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido");
        }

        private ValidationResult ValidarSenha(object value, string displayField)
        {           
            var result = Regex.IsMatch(value.ToString(), @"^([a-zA-Z0-9]{8,15})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido");
        }
        
        private ValidationResult ValidarNome(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-ZÀ-Ÿ][A-zÀ-ÿ']+\s([A-zÀ-ÿ']\s?)*[A-ZÀ-Ÿ][A-zÀ-ÿ']+$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido");
        }

        private ValidationResult ValidarLogin(object value, string displayField)
        {

            Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());
            //verificar se o login já existe           


            return new ValidationResult($"O campo {displayField} é inválido");
        }
    }
}