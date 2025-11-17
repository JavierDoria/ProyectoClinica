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
    public partial class Popularidad : Form
    {
        public Popularidad()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Crear valores aleatorios entre 10 y 100
            int med = rnd.Next(10, 100);
            int ped = rnd.Next(10, 100);
            int trauma = rnd.Next(10, 100);
            int odonto = rnd.Next(10, 100);

            // Asignar valores a las barras
            MedicinaGeneral.Value = med;
            medi.Text = med + "%";

            Pediatria.Value = ped;
            pedi.Text = ped + "%";

            Traumotologia.Value = trauma;
            tra.Text = trauma + "%";

            Odontologia.Value = odonto;
            odo.Text = odonto + "%";
        }
    }
}
