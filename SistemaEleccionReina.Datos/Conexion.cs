using System;
using System.Data.OleDb;

namespace SistemaEleccionReina.Datos
{
    public class Conexion
    {
        private string cadenaConexion =
        @"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=C:\Users\Samsung\source\repos\SistemaMvc_EleccionesReina\EleccionReina1.accdb;
Persist Security Info=False;";


        public OleDbConnection ObtenerConexion()
        {
            return new OleDbConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (OleDbConnection conn = ObtenerConexion())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

