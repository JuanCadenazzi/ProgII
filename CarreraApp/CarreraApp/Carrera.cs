using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraApp
{
    internal class Carrera
    {

        private List<DetalleCarrera> lDetalles;
        public List<DetalleCarrera> Detalles
        {
            set { lDetalles = value; }
            get { return lDetalles; }
        }

        private int codigo;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nombre;

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string titulo;

        public bool disponible { get; set; }
        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Carrera()
        {
            this.nombre = "";
            this.titulo = "";
            codigo = 0;
            lDetalles = new List<DetalleCarrera>();

        }

        public Carrera(string nombre, string titulo, int codigo, List<DetalleCarrera> detalleCarreras)
        {
            this.nombre = nombre;
            this.titulo = titulo;
            this.codigo = codigo;
            this.Detalles = detalleCarreras;

        }

        public void agregarDetalle(DetalleCarrera detalle)
        {
            lDetalles.Add(detalle);
        }
        public void quitarDetalle(int indice)
        {
            lDetalles.RemoveAt(indice);
        }


        public override string ToString()
        {
            return nombre + " - " + titulo;
        }

    }
}
