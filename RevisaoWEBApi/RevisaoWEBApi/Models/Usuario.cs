using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class Usuario : UserControls
    {
        [Key] //atributo das propriedades       
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)] //o mesmo que: [CustomValidFields((Enums.ValidFields)3)]  sendo 3 o número criado pelo Enum
        public string Nome { get; set; }

       [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaLogin)]
        public string Login { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaSenha)]       
        public string Senha { get; set; }
    }
}