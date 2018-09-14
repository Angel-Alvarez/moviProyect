using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class clsInventario
    {
        string clave;
        string nombre;
        string rutaImg;
        double precio;
        string proovedor;
        int existencia;
        string descripcion;

        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string RutaImg { get => rutaImg; set => rutaImg = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Proovedor { get => proovedor; set => proovedor = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
