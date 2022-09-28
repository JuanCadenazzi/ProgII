using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.dominio
{
    public class Ingredientes
    {

       

        public int ingredeinteID { get; set; }

        public int Unidad { get; set; }

        public string Nombre { get; set; }

        public Ingredientes()
        {
            ingredeinteID = 0;
            Unidad = 0;
            Nombre = string.Empty;
        
        }
        public Ingredientes(int ingredienteID,int unidad,string nombre)
        {

            this.ingredeinteID = ingredienteID;
            this.Unidad = unidad;
            this.Nombre = nombre;

        }
        public Ingredientes(int ingredienteID,  string nombre)
        {

            this.ingredeinteID = ingredienteID;
          
            this.Nombre = nombre;

        }
        public override string ToString()
        {
            return Nombre; 
        }

    }
}
