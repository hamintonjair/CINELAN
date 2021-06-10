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
    public partial class FormInformacion : Form
    {
        FormPrincipal formPrinci;



        public bool Invisible { get; private set; }

        
        public FormInformacion(FormPrincipal formPrincipal) //Modificado
        {
            InitializeComponent();
            formPrinci = formPrincipal;

            /*
            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.TipoCliente, venta.Cliente.Nombre, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.Comestibles);
            }
            */
            
            
        }
        //metodo para que 

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("tipo", "Tipo");
            dataGridView1.Columns.Add("pelicula", "Pelicula");
            dataGridView1.Columns.Add("sala", "Sala");
            dataGridView1.Columns.Add("asiento", "Asiento");
            dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("comestibles", "Comestibles");

            /*
            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.TipoCliente, venta.Cliente.Nombre, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.getValorComestible());
            } 
            */

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre,venta.Cliente.TipoCliente ,venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.getValorComestible());
            }
        }

        private void FormInformacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrinci.Visible = true;
        }

        //metodo para los que realizaron compras
        private void btnCompraronCOmida_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            //dataGridView1.Columns.Add("pelicula", "Pelicula");
            //dataGridView1.Columns.Add("sala", "Sala");
            //dataGridView1.Columns.Add("asiento", "Asiento");
            //dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("comestibles", "Comestibles");

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Comestibles != "Ninguno")
                {
                    dataGridView1.Rows.Add(venta.Cliente.Nombre,/* venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor,*/ venta.Comestibles);
                }
            }
        }

        private void btnNoCompraronComida_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("pelicula", "Pelicula");
            dataGridView1.Columns.Add("sala", "Sala");
            dataGridView1.Columns.Add("asiento", "Asiento");
            dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("comestibles", "Comestibles");

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Comestibles == "Ninguno")
                {
                    dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, "Ninguno");
                }
            }
        }

        private void btnPersonasEdades_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("edad", "Edad");


            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.Edad);
            }
        }

        private void btnDineroSala_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            int sumaSala1 = 0;
            int sumaSala2 = 0;
            int sumaSala3 = 0;
            int sumaSala4 = 0;

            dataGridView1.Columns.Add("nombreCliente", "Sala");
            dataGridView1.Columns.Add("edad", "Cantidad");

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Sala == "Sala 1")
                {
                    sumaSala1 += venta.Valor;
                }
                else if (venta.Sala == "Sala 2")
                {
                    sumaSala2 += venta.Valor;
                }
                else if (venta.Sala == "Sala 3")
                {
                    sumaSala3 += venta.Valor;
                }
                else if (venta.Sala == "Sala 4")
                {
                    sumaSala4 += venta.Valor;
                }
            }

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Sala == "Sala 1")
                {
                    dataGridView1.Rows.Add(venta.Sala, sumaSala1);
                }
                if (venta.Sala == "Sala 2")
                {
                    dataGridView1.Rows.Add(venta.Sala, sumaSala2);
                }
                if (venta.Sala == "Sala 3")
                {
                    dataGridView1.Rows.Add(venta.Sala, sumaSala3);
                }
                if (venta.Sala == "Sala 4")
                {
                    dataGridView1.Rows.Add(venta.Sala, sumaSala4);
                }
            }

        }
        //recorrido de las peliculas mas vista
        private void btnPeliculaMasVista_Click(object sender, EventArgs e)
        {

            int pelicula3metro = 0;
            int peliculamenteMaravillosa = 0;
            int peliculaTitanic = 0;
            int peliculaNacidoParaMatar = 0;

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Pelicula == "3 metros sobre el cielo")
                {
                    pelicula3metro++;
                }
                else if (venta.Pelicula == "Mente Maravillosa")
                {
                    peliculamenteMaravillosa++;
                }
                else if (venta.Pelicula == "Titanic")
                {
                    peliculaTitanic++;
                }
                else if (venta.Pelicula == "Nacidos Para Matar")
                {
                    peliculaNacidoParaMatar++;
                }
            }

            List<int> masVista = new List<int>();
            masVista.Add(pelicula3metro);
            masVista.Add(peliculamenteMaravillosa);
            masVista.Add(peliculaTitanic);
            masVista.Add(peliculaNacidoParaMatar);
            foreach (int vista in masVista)
            {

            }
            if (pelicula3metro > peliculamenteMaravillosa && pelicula3metro > peliculaTitanic && pelicula3metro > peliculaNacidoParaMatar)
            {
                txtPeliculaMasVista.Text = "3 Metros sobre el cielo";
            }
            else if (peliculamenteMaravillosa > pelicula3metro && peliculamenteMaravillosa > peliculaTitanic && peliculamenteMaravillosa > peliculaNacidoParaMatar)
            {
                txtPeliculaMasVista.Text = "Mente Maravillosa";
            }
            else if (peliculaTitanic > peliculamenteMaravillosa && peliculaTitanic > pelicula3metro && peliculaTitanic > peliculaNacidoParaMatar)
            {
                txtPeliculaMasVista.Text = "Titanic";
            }
            else
            {
                txtPeliculaMasVista.Text = "Hay un empate";
            }
        }
        //total de las ventas por cada comida
        private void btnTotalVentaComida_Click(object sender, EventArgs e)
        {

            int TotalPorComida = 0;


            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                if (venta.Comestibles != "")
                {
                    if (venta.Comestibles.Equals("Crispetas"))
                    {
                        TotalPorComida += 2000;
                    }
                    else if (venta.Comestibles.Equals("Gaseosa"))
                    {
                        TotalPorComida += 2500;
                    }
                    else if (venta.Comestibles.Equals("Hot dog"))
                    {
                        TotalPorComida += 4500;
                    }
                    else if (venta.Comestibles.Equals("Papas"))
                    {
                        TotalPorComida += 3000;
                    }
                    else
                    {
                        TotalPorComida += 0;
                    }


                    //TotalPorComida += 2000;

                }
            }

            txtTotalVentasComida.Text = TotalPorComida.ToString();
        }
        //total de las ventas de comid en el cine
        private void TotalVentaComidaYCine_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {

                total += venta.Valor;

            }
            txtTotalVentasComidaYCIne.Text = total.ToString() ;
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {
            /*
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("pelicula", "Pelicula");
            dataGridView1.Columns.Add("sala", "Sala");
            dataGridView1.Columns.Add("asiento", "Asiento");
            dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("comestibles", "Comestibles");

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.getValorComestible());
            }
            */
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("tipo", "Tipo");
            dataGridView1.Columns.Add("pelicula", "Pelicula");
            dataGridView1.Columns.Add("sala", "Sala");
            dataGridView1.Columns.Add("asiento", "Asiento");
            dataGridView1.Columns.Add("valor", "Valor");
            dataGridView1.Columns.Add("comestibles", "Comestibles");

            /*
            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.TipoCliente, venta.Cliente.Nombre, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.getValorComestible());
            } 
            */

            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.TipoCliente, venta.Pelicula, venta.Sala, venta.Asiento, venta.Valor, venta.getValorComestible());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            formPrinci.Visible = true;
        }
        //metodo para muestre el tipo de cliente
        private void button1_Click(object sender, EventArgs e)
        {
         
            dataGridView1.Rows.Clear();
          

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nombreCliente", "Cliente");
            dataGridView1.Columns.Add("tipo", "Tipo");


            foreach (VentaPelicula venta in FormPrincipal.ListaVentaPelicula)
            {
                dataGridView1.Rows.Add(venta.Cliente.Nombre, venta.Cliente.TipoCliente);
            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}