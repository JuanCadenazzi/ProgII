using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form1 : Form
    {
        private iColleccion colleccion;
        public Form1()
        {
            InitializeComponent();
            colleccion = new Pila(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            object pila = txtCargar.Text;
            if (!string.IsNullOrEmpty(txtCargar.Text))
            {
                lstElementos.Items.Add(pila);
                MessageBox.Show("Se cargado con exito", "Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lista llena!", "Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object pila = colleccion.extraer();
            lstElementos.Items.Remove(pila);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!colleccion.estaVacia())
            {
                MessageBox.Show("Primer carga: " + colleccion.primero(), "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnVacia_Click(object sender, EventArgs e)
        {
            string mensaje = colleccion.estaVacia() ? "lista Vacia" : "lista con elementos";
            MessageBox.Show(mensaje, "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
