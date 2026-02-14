using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using SistemaEleccionReina.Modelo;

namespace SistemaEleccionReina.Datos
{
    public class VotoRepositorio
    {
        private Conexion conexion = new Conexion();

        public bool YaVoto(int idEstudiante, string tipoVotacion)
        {
            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Votos WHERE IdEstudiante = ? AND TipoVotacion = ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idEstudiante);
                cmd.Parameters.AddWithValue("?", tipoVotacion);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }

        public void RegistrarVoto(Voto voto)
        {
            using (OleDbConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO Votos 
                                 (IdCandidata, IdEstudiante, TipoVotacion, Fecha) 
                                 VALUES (?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", voto.IdCandidata);
                cmd.Parameters.AddWithValue("?", voto.IdEstudiante);
                cmd.Parameters.AddWithValue("?", voto.TipoVotacion);
                cmd.Parameters.AddWithValue("?", voto.Fecha);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
