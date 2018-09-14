using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaNegocio;
using System.Data;
using MySql.Data.MySqlClient;

namespace capaDatos
{
    class clsDatosInventario
    {
        clsConexion cone = new clsConexion();
        public void AgregarProducto(clsInventario objProducto)
        {
            string sql;
            MySqlCommand cm;
            cone.conectar();
            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@clave", objProducto.Clave);
            cm.Parameters.AddWithValue("@imgProducto", objProducto.RutaImg);
            cm.Parameters.AddWithValue("@nombre", objProducto.Nombre);
            cm.Parameters.AddWithValue("@proovedor", objProducto.Proovedor);
            cm.Parameters.AddWithValue("@precio", objProducto.Precio);
            cm.Parameters.AddWithValue("@existencia", objProducto.Existencia);
            cm.Parameters.AddWithValue("@descripcion", objProducto.Descripcion);

            sql = "INSERT INTO documentos (clave, imgProducto, nombre, proovedor, precio, existencia, descripcion) " +
            "VALUES (@clave, @imgProducto, @nombre, @proovedor, @precio, @existencia, @descripcion)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cone.cn;
            cm.ExecuteNonQuery();
            cone.cerrar();
        }
    }
}
