using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Enums
{
    public enum ValidFields //não é uma classe, é um enum (foi alterado manualmente)
    {
        ValidaLogin, //0 são os números por default, ou escolhe os números com = número (= 5, por exemplo)
        ValidaEmail, //1
        ValidaSenha, //2
        ValidaNome   //3
    }

}