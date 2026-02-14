using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using SistemaEleccionReina.Modelo;

namespace SistemaEleccionReina.Datos
{
    public class EstudianteRepositorio
    {
        private Conexion conexion = new Conexion();

        public void Insertar(Estudiante estudiante)
        {
            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Estudiantes (Nombre, Matricula) VALUES (?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", estudiante.Nombre);
                cmd.Parameters.AddWithValue("?", estudiante.Matricula);

                cmd.ExecuteNonQuery();
            }
        }

        public Estudiante ObtenerPorMatricula(string matricula)
        {
            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Estudiantes WHERE Matricula = ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", matricula);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Estudiante
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Matricula = reader["Matricula"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
