using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINELAN
{
   
    class VentaPelicula
    {
        Cliente cliente;
        string pelicula;
        string sala;
        int asiento;
        int valor;
        string comestible;
        int valorComestible;

        //Metodos getters y setters
        internal Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int getValorComestible()
        {
            return valorComestible;
        }

        public void setValorComestible(int i)
        {
            valorComestible = i;
        }

        public int ValorComestible
        {
            get { return valorComestible; }
            set { valorComestible = value; }
        }

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        public string Pelicula
        {
            get { return pelicula; }
            set { pelicula = value; }
        }
        

        public string Sala
        {
            get { return sala; }
            set { sala = value; }
        }
        

        public int Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }
        

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        

        public string Comestibles
        {
            get { return comestible; }
            set { comestible = value; }
        }

        public void setComestible(String comestible)
        {
            this.comestible = comestible;
        }

        
    }
}
