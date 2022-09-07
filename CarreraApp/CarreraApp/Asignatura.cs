using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraApp
{
    public class Asignatura
    {

        private int codigo;
        private string nombre;

        public int pCodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }

        }


        public Asignatura()
        {
            this.nombre = "";
            this.codigo = 0;
        }
        public Asignatura(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }


        public override string ToString()
        {
            return "Nombre" + nombre;
        }
    }
}
