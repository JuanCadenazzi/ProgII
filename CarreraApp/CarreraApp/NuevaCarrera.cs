using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarreraApp
{
    public partial class frmNuevaCarrera : Form
    {
        AccesoDatos oBD;
        Carrera nvCarrera;
        public frmNuevaCarrera()
        {
            InitializeComponent();
            oBD = new AccesoDatos();
            nvCarrera = new Carrera();
        }

        private void frmNuevaCarrera_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(@"Data Source=JUAN-NB\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SP_MOSTRAR_ASIGNATURA", conexion);
            conexion.Open();
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(comando.ExecuteReader());
            cboAsignatura.DataSource = tabla;
            cboAsignatura.DisplayMember = "nombre";
            cboAsignatura.ValueMember = "cod_materia";
            cboAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Close();

        }

        private void btbAgregar_Click(object sender, EventArgs e)
        {
            if (cboAsignatura.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar una Asignatura !",
                      "Control", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
                return;

            }
            if (txtAñoCursado.Text == "" || !int.TryParse(txtAñoCursado.Text, out _))
            {
                MessageBox.Show("Debe ingresar un año válida!",
                 "Control", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                return;
            }
            if (!rbtPrimer.Checked && !rbtSegundo.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre",
                 "Control", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                return;
            }

            //foreach (DataGridViewRow row in dgvDetalle.Rows)
            //{
            //    if (row.Cells["colAsignatura"].Value.ToString().Equals(cboAsignatura.Text))
            //    {
            //        MessageBox.Show("ASIGANATURA: " + cboAsignatura.Text + "ya esta cargada",
            //            "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            Asignatura a = new Asignatura();
            a.pCodigo = Convert.ToInt32(cboAsignatura.SelectedValue);
            a.pNombre = cboAsignatura.Text;
            int anioCursado = Convert.ToInt32(txtAñoCursado.Text);
            string cuatrimestre = "Primero";
            if (rbtSegundo.Checked)
            {
                cuatrimestre = "Segundo";
            }
            DetalleCarrera d = new DetalleCarrera(anioCursado, cuatrimestre, a);
            nvCarrera.agregarDetalle(d);
            dgvDetalle.Rows.Add(a.pCodigo, a.pNombre, anioCursado, cuatrimestre);




        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                nvCarrera.quitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }


       
    }
}
