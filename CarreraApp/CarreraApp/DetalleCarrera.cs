using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraApp
{
    internal class DetalleCarrera
    {

        private int anioCursado;

        public int pAnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }
        private string cuatrimestre;

        public string pCustrismestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }
        private Asignatura asignatura;

        public Asignatura pAsigantura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
       


        private int codgo;

        public int pCodigo
        {
            get { return codgo; }
            set { codgo = value; }
        }


        public DetalleCarrera()
        {
            this.anioCursado = 0;
            this.cuatrimestre = "";
            asignatura = new Asignatura();

        }

        public DetalleCarrera(int anioCursado, string cuatrimestre, Asignatura asiganturas, int codigo)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.asignatura = asiganturas;
            this.codgo = codigo;


        }
        public DetalleCarrera(int anioCursado, string cuatrimestre, Asignatura asiganturas)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.asignatura = asiganturas;

        }


        public override string ToString()
        {
            return "Asignatura" + asignatura.ToString() + "año cursado" + anioCursado + " cuatrimestre " + cuatrimestre;
        }

    }
}
