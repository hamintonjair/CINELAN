using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CINELAN
{
    public partial class Ayuda : Form
    {
        FormPrincipal form = new FormPrincipal();
        private FormInformacion formInformacion;

        public Ayuda(FormPrincipal form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void Uno_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva2;
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva1;
        }
        
        private void Quince_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva15;
        }

        private void Dieciseis_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva16;
        }

        private void Diecinueve_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva19;
        }

        private void Dieciocho_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva18;
        }

        private void Diecisiete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva17;
        }

        private void Veinte_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva20;
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva3;
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva4;
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva5;
            
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva6;
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva7;
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva9;
        }

        private void Diez_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva10;
        }

        private void Once_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva11;
        }

        private void Doce_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva12;
        }

        private void Trece_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva13;
        }

        private void Catorce_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CINELAN.Properties.Resources.Diapositiva14;
        }
    }
}
