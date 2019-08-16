using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contacto ()
        {
            Nombre = "Sin nombre";
            Celular = "Sin celular";
            Telefono = "Sin telefono";
            Correo = "Sin correo";
            Direccion = "Sin direccion";
        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin ceular";
            Telefono = "Sin telefono";
            Direccion = "Sin direccion";


        }
        public Contacto(string nombre, string celular, string telefono, string correo, string direccion)
        {
            Nombre = nombre;
            Celular = celular;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }


    }
}
