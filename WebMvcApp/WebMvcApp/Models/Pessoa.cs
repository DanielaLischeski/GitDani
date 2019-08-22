using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //ctrl+. em [Key]
using System.Linq;
using System.Web;

namespace WebMvcApp.Models
{
    public class Pessoa : UserControls
    {
        [Key] //será usado como referência
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}