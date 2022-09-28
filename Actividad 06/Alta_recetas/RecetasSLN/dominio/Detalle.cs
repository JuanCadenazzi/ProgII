using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
	internal class Detalle
	{
		private Ingredientes ingrediente;

		public Ingredientes Ingrediente
		{
			get { return ingrediente; }
			set { ingrediente = value; }
		}

		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		public Detalle()
		{
			ingrediente = new Ingredientes();
			cantidad = 0;
		}
		public Detalle(Ingredientes ingrediente,int cantidad)
		{
			this.ingrediente = new Ingredientes();
			this.cantidad = cantidad;
		}

	}
}
