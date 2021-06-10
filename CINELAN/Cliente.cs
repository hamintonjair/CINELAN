using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINELAN
{
    class Cliente
    {
        string documento;
        string nombre;
        string apellido;
        int edad;
        string tipoCliente;

        //Propiedad Documento
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        
        //Propiedad Nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        //Propiedad Apellido
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
       
        //Propiedad Edad
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        
        //Propiedad TipoCliente
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        //-----------------------------------------
        public String getDocumento()
        {
            return documento;
        }

        public void setDocumento(String documento)
        {
            this.documento = documento;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getApellido()
        {
            return apellido;
        }

        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public String getTipoCliente()
        {
            return tipoCliente;
        }

        public void setTipoCliente(String tipoCliente)
        {
            this.tipoCliente = tipoCliente;
        }

    }
}
