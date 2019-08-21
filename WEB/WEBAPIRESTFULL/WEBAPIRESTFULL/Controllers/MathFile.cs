using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
    public class MathFile : Single<MathFile>
    {
        BibliotecaContextDB bibliotecaContextDB = new BibliotecaContextDB();

        public int QuantidadeUsuarios() //irá contar os usuários
        {
            return bibliotecaContextDB.Usuarios.Count();

        }
    }
}