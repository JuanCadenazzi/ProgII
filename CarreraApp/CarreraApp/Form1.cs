using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaCarrera nueva = new frmNuevaCarrera();
            nueva.ShowDialog();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteAsignatura reporte = new ReporteAsignatura();
            reporte.ShowDialog();

        }

        private void asignatura1SemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerSem nuevo = new PrimerSem();
            nuevo.ShowDialog();
        }
    }
}
