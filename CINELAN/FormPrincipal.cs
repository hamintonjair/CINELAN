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
    public partial class FormPrincipal : Form
    {
        int asiento = 1;


        List<Cliente> ListaClientes = new List<Cliente>();
        List<String> listaComestible = new List<string>();

        internal static List<VentaPelicula> ListaVentaPelicula = new List<VentaPelicula>();
        


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
           
            
        }

        private void btAgregarEsteCliente_Click(object sender, EventArgs e)
        {
            Cliente NuevoCliente = new Cliente();
            if (txtDocumento.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && comboBoxTipoCliente.Text != "")
            {
                try
                {
                    NuevoCliente.Documento = txtDocumento.Text;
                    NuevoCliente.Nombre = txtNombre.Text;
                    NuevoCliente.Apellido = txtApellido.Text;
                    NuevoCliente.Edad = int.Parse(txtEdad.Text);
                    NuevoCliente.TipoCliente = comboBoxTipoCliente.Text;
                    //----
                    
                    ListaClientes.Add(NuevoCliente);

                    MessageBox.Show("Agregado");

                    LimpiarCajas();

                        comboBoxClientePelicula.Items.Add(NuevoCliente.Nombre);

                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error, registre sus datos correctamente e intente de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }

        }

        private void LimpiarCajas()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            comboBoxTipoCliente.SelectedIndex = -1;

        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            VentaPelicula NuevaVentaPelicula = new VentaPelicula();
            double total = 0;
            int valor=0;

                txtAsiento.Text = asiento.ToString();

                //agregar la compra del cliente
                try
                {
                    if (comboBoxClientePelicula.Text.Length != 0)
                    {
                        Cliente elCliente = new Cliente();

                        foreach (Cliente cli in ListaClientes)
                        {
                            if (cli.Nombre == comboBoxClientePelicula.Text)
                            {
                                elCliente.Documento = cli.Documento;
                                elCliente.Nombre = cli.Nombre;
                                elCliente.Apellido = cli.Apellido;
                                elCliente.Edad = cli.Edad;
                                elCliente.TipoCliente = cli.TipoCliente;

                                if (cli.Edad < 5)
                                {
                                    valor = 5000;
                                }

                                else if (cli.Edad >= 5 && cli.Edad < 18)
                                {
                                    valor = 6000;
                                }

                                else if (cli.Edad >= 18 && cli.Edad < 50)
                                {
                                    valor = 8000;
                                }
                                else if (cli.Edad >= 50)
                                {
                                    valor= 7000;
                                }                                                               
                            }
                        }
                        //txtValor.Text = total;

                        int valorComestible = 0;
                        if (RBCrispetas.Checked == true)
                        {
                            NuevaVentaPelicula.Comestibles = "Crispetas";
                            valorComestible = 2000;
                        }
                        else if (RBGaseosa.Checked == true)
                        {
                            NuevaVentaPelicula.Comestibles = "Gaseosa";
                            valorComestible = 2500;
                        }
                        else if (RBHotDog.Checked == true)
                        {
                            NuevaVentaPelicula.Comestibles = "Hot dog";
                            valorComestible = 4500;
                        }
                        else if (RBPapas.Checked == true)
                        {
                            NuevaVentaPelicula.Comestibles = "Papas";
                            valorComestible = 3000;
                        }
                        else if (RBNinguno.Checked == true)
                        {
                            NuevaVentaPelicula.Comestibles = "Ninguno";
                            valorComestible = 0;
                        }
                        //mod
                        valor = valor + valorComestible;

                        NuevaVentaPelicula.Cliente = elCliente;
                        NuevaVentaPelicula.Pelicula = comboBoxPelicula.Text;
                        NuevaVentaPelicula.Sala = comboBoxSala.Text;
                        NuevaVentaPelicula.Asiento = int.Parse(txtAsiento.Text);
                        //Modificado
                        NuevaVentaPelicula.ValorComestible = valorComestible; 
                        NuevaVentaPelicula.setValorComestible(valorComestible);

                        
                       /// tipos de clientes*/
                    
                        if (NuevaVentaPelicula.Cliente.TipoCliente == "VIP"  )
                        {
                            total= valor - (10 * valor ) / 100;
                        }
                        if (NuevaVentaPelicula.Cliente.TipoCliente == "Oro")
                        {
                          total = valor - (5 * valor) / 100;
                        }
                        if (NuevaVentaPelicula.Cliente.TipoCliente == "Plata")
                        {
                           total = valor - (5 * valor) / 100;
                        }

                        NuevaVentaPelicula.Valor = Convert.ToInt32(total);

                        txtValor.Text = valor.ToString();

                        txtTotal.Text = total.ToString();

                        ListaVentaPelicula.Add(NuevaVentaPelicula);

                        double resta = double.Parse(txt_valoPagar.Text);

                        MessageBox.Show("Registro exitoso...." + Environment.NewLine +
                            "Devolver al cliente el valor de : " + (total - double.Parse(txt_valoPagar.Text)));
                        asiento++;

                        comboBoxPelicula.SelectedIndex = -1;
                        comboBoxClientePelicula.SelectedIndex = -1;
                        comboBoxSala.SelectedIndex = -1;
                        txtValor.Text = "";
                        txtTotal.Text = "";
                        txtAsiento.Text = asiento.ToString();
                        RBNinguno.Checked = true;                        

                    }
                    else
                    {
                        MessageBox.Show("Debe elegir un cliente para poder hacer la venta");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un error, corrija sus datos");
                }
                    LimpiarCajas();
        }
        

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            FormInformacion  Informacion = new FormInformacion(this);
            this.Visible=false;
            Informacion.ShowDialog();
          
        }

        private void btnVerPromocion_Click(object sender, EventArgs e)
        {
            FormPromocionesYDescuento promocion = new FormPromocionesYDescuento();
            promocion.ShowDialog();
        }

      
        private void modificarValores(String documento, String nombre, String apellido, int edad, String tipoCliente, String comestible, String nombreBuscado)
        {
            foreach (VentaPelicula pelicula in ListaVentaPelicula)
            {

                if (pelicula.getCliente().getNombre().Equals(nombreBuscado))
                {
                    pelicula.getCliente().setDocumento(documento);
                    pelicula.getCliente().setNombre(nombre);
                    pelicula.getCliente().setApellido(apellido);
                    pelicula.getCliente().setEdad(edad);
                    pelicula.getCliente().setTipoCliente(tipoCliente);
                    pelicula.setComestible(comestible);
                }

            }
            
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (VentaPelicula pelicula in ListaVentaPelicula)
            {
                contador++;
                if (pelicula.getCliente().getNombre().Equals(txt_nombreActua.Text))
                {

                    pelicula.getCliente().setDocumento(txt_Documento.Text);
                    pelicula.getCliente().setNombre(txt_Nombre.Text);
                    pelicula.getCliente().setApellido(txt_Apellido.Text);
                    pelicula.getCliente().setEdad(int.Parse(txt_AEdad.Text));
                    pelicula.getCliente().setTipoCliente(comboBox1.Text);

                    //----Modificar

                    String comestible = "";
                    if (rb_Acrirspetas.Checked == true)
                    {
                        comestible = "Crispetas";

                    }
                    else if (rb_Agaseosa.Checked == true)
                    {
                        comestible = "Gaseosa";
                    }
                    else if (rb_AhotDog.Checked == true)
                    {
                        comestible = "Hot dog";
                    }
                    else if (rb_Apapas.Checked == true)
                    {
                        comestible = "Papas";
                    }
                    else if (rd_Aninguno.Checked == true)
                    {
                        comestible = "Ninguno";
                    }
                    //----Fin modificar
                    pelicula.setComestible(comestible);

                    MessageBox.Show("Actualziado con exito!!!");
                    break;
                }
                else
                {
                    MessageBox.Show("No encontrado!");
                    break;
                }
            }          

            if (contador ==0)
            {
                MessageBox.Show("No encontrado!");                
            }
            txt_nombreActua.Text = "";
            txt_Documento.Text = "";
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_AEdad.Text = "";
            comboBox1.Text = "";
        }
        private void RBPapas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda(this);
            ayuda.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade(this);
            acercade.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
