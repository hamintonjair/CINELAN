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
    public partial class Acercade : Form
    {
        FormPrincipal form = new FormPrincipal();
        private FormInformacion formInformacion;
        public Acercade(FormPrincipal form)
        {
            InitializeComponent();
        }

        private void Acercade_Load(object sender, EventArgs e)
        {

        }
    }
}
