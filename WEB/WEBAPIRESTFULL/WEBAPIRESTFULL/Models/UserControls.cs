using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPIRESTFULL.Models
{
    public class UserControls
    {
        public bool? Ativo { get; set; } = true;

        public int? UsuInc { get; set; } = 2;

        public int? UsuAlt { get; set; } = 2;

        public DateTime? DatInc { get; set; } = DateTime.Now;

        public DateTime? DatAlt { get; set; } = DateTime.Now;
    }
}