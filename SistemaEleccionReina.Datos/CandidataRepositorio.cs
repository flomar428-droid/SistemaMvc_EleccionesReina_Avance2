using System;
using System.Collections.Generic;
using System.Data.OleDb;
using SistemaEleccionReina.Modelo;

namespace SistemaEleccionReina.Datos
{
    public class CandidataRepositorio
    {
        private Conexion conexion = new Conexion();

        public void Insertar(Candidata candidata)
        {
            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO Candidatas 
                                (Nombre, Carrera, Edad, Pasatiempos, Habilidades, Intereses, Aspiraciones, FotoPrincipal) 
                                VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("?", candidata.Nombre);
                cmd.Parameters.AddWithValue("?", candidata.Carrera);
                cmd.Parameters.AddWithValue("?", candidata.Edad);
                cmd.Parameters.AddWithValue("?", candidata.Pasatiempos);
                cmd.Parameters.AddWithValue("?", candidata.Habilidades);
                cmd.Parameters.AddWithValue("?", candidata.Intereses);
                cmd.Parameters.AddWithValue("?", candidata.Aspiraciones);
                cmd.Parameters.AddWithValue("?", candidata.FotoPrincipal);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Candidata> ObtenerTodas()
        {
            List<Candidata> lista = new List<Candidata>();

            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Candidatas";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Candidata c = new Candidata();

                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Nombre = reader["Nombre"].ToString();
                    c.Carrera = reader["Carrera"].ToString();
                    c.Edad = Convert.ToInt32(reader["Edad"]);
                    c.Pasatiempos = reader["Pasatiempos"].ToString();
                    c.Habilidades = reader["Habilidades"].ToString();
                    c.Intereses = reader["Intereses"].ToString();
                    c.Aspiraciones = reader["Aspiraciones"].ToString();
                    c.FotoPrincipal = reader["FotoPrincipal"].ToString();

                    lista.Add(c);
                }
            }

            return lista;
        }
    }
}
