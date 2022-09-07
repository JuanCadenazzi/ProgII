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
    public partial class PrimerSem : Form
    {
        public PrimerSem()
        {
            InitializeComponent();
        }

        private void PrimerSem_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.SP_REPORTE_PRIMER_SEMESTRE' Puede moverla o quitarla según sea necesario.
            this.sP_REPORTE_PRIMER_SEMESTRETableAdapter.Fill(this.universidadDataSet.SP_REPORTE_PRIMER_SEMESTRE);

            this.reportViewer1.RefreshReport();
        }
    }
}
