using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    public class Pila : iColleccion
    {
        private object[] array;
        private int contador;

        public Pila (int cantidad)
        {
            contador = -1;
            array = new object[cantidad];
        }
        
        public bool añadir(object elemento)
        {
            bool agregado = false;
            if (contador<array.Length)
            {
                array[++contador] = elemento;
                agregado = true;                   
            }
            return agregado;
        }


        public bool estaVacia()
        {
            return contador == -1;
        }
        public object extraer()
        {

            object a = null;
            if (!estaVacia())
            {
                a = array[contador];
                array[contador] = null;
                contador--;
            }
            return a;

        }
        public object primero()
        {
            object a = null;
            if(!estaVacia())
            {
                a = array[0];

            }
            return a;
        }

        
    }
}
