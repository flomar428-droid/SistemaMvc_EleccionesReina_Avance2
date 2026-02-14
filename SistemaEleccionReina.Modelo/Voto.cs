using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    public class Voto
    {
        public int Id { get; set; }
        public int IdCandidata { get; set; }
        public int IdEstudiante { get; set; }
        public string TipoVotacion { get; set; }
        // "Reina" o "MissFotogenia"

        public DateTime Fecha { get; set; }

        public Voto() { }

        public Voto(int idCandidata, int idEstudiante, string tipoVotacion)
        {
            IdCandidata = idCandidata;
            IdEstudiante = idEstudiante;
            TipoVotacion = tipoVotacion;
            Fecha = DateTime.Now;
        }
    }
}
