using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoInterfaceCarro.Interface
{
    interface IIgual<T>
    {
        bool Comparar(T obj); //bool é o tipo de retorno que este método irá ter
    }
}
