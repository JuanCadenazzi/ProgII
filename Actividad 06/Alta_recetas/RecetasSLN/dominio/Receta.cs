using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
		private int recetaNro;

		public int RecetaNro
		{
			get { return recetaNro; }
			set { recetaNro = value; }
		}

		public int tipoReceta { get; set; }


		public string nombre { get; set; }
		public string chef { get; set; }

		public List<Detalle> detalles { get; set; }

		public Receta()
		{
			detalles = new List<Detalle>();
		}

		public void agregarDetalle(Detalle detalleR)
		{
			detalles.Add(detalleR);
		}

		public void quitarDetalle(int indice)
		{
			detalles.RemoveAt(indice);
		}


		public Receta(int recetaNro,int tipoReceta,string nombre, string chef)
		{
			this.recetaNro = recetaNro;
			this.tipoReceta = tipoReceta;
			this.nombre = nombre;
			this.chef = chef;

		}




	}
}
