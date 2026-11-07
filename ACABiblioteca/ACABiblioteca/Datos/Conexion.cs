using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ACABiblioteca.Datos
{
    
        public class Conexion
        {
            private string cadenaConexion = "Server=.;Database=ACABiblioteca;Integrated Security=True;TrustServerCertificate=True;";

        public  SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

    }
}

