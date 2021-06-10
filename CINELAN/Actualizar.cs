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
    public partial class Actualizar : Form
    {
        FormPrincipal formdi = new FormPrincipal();
        private FormInformacion formInformacion;

        FormPrincipal formOne;

        
        public Actualizar(FormPrincipal form)
        {
            InitializeComponent();

            

            this.formOne = form;

            comboBoxTipoCliente.Items.Add("VIP");
            comboBoxTipoCliente.Items.Add("Oro");
            comboBoxTipoCliente.Items.Add("Plata");
            comboBoxTipoCliente.Items.Add("General");


            comboBoxTipoCliente.Items.Add("Sala");
            
            
        }

        public Actualizar(FormInformacion formInformacion)
        {
            this.formInformacion = formInformacion;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
           // formOne.
        }
    }
}
