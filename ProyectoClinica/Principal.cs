using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void cerrar()
        {
            foreach(Form frm in this.MdiChildren){
                frm.Close();
            }
        }

        
        private void pACIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrar();
            Pacientes frm = new Pacientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mEDICINASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrar();
            FormMedicina frm = new FormMedicina();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rECETASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrar();
            FormReceta frm = new FormReceta();
            frm.MdiParent = this;
            frm.Show();

        }

        private void eSPECIALIDADESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrar();
            Especialidades frm = new Especialidades();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar();
            FormDoctores frm = new FormDoctores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pOPULARIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar();
            Popularidad frm = new Popularidad();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
