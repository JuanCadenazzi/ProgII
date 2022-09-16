using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    public interface iColleccion 
    {
        bool añadir(object elemento);
        bool estaVacia();
        object extraer();

        object primero();





    }
}
