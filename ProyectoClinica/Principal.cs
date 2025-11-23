using ProyectoClinica.Entities;
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
        private Login usuarioLogeado;
        public Principal(Login usuario)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            usuarioLogeado = usuario;
            ConfigurarPorRol();
        }
        private void ConfigurarPorRol()
        {
            int rol = usuarioLogeado.Roles.id_Roles;

            if (rol == 1)
                return; // ADMIN no se oculta nada

            if (rol == 2) // DOCTOR
            {
                pOPULARIDADToolStripMenuItem.Visible = false;
                mantenimientoToolStripMenuItem.Visible = false;
            }
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

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
