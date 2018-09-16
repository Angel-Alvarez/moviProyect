using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class clsLogn
    {
        private string nombre, tipo, contrasenia;

        public clsLogn(string nombre, string tipo, string contrasenia)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Contrasenia = contrasenia;

        }

        public clsLogn()
        {
        }

        public string Nombre { get => nombre;
            set { if (value == "Usuario") { nombre = "No ha ingresado usuario"; } else { nombre = value; } } }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Contrasenia { get => contrasenia; set { if (value == "Contraseña") { contrasenia = "No ha ingresado contraseña"; } else { contrasenia = value; } } }
    }
}
