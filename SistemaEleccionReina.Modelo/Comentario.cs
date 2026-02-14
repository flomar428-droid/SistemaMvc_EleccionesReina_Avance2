using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    internal class Comentario
    {
        public int Id { get; set; }
        public int IdFoto { get; set; }
        public int IdEstudiante { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }

        public Comentario()
        {
            Fecha = DateTime.Now;
        }

        public Comentario(int idFoto, int idEstudiante, string texto)
        {
            IdFoto = idFoto;
            IdEstudiante = idEstudiante;
            Texto = texto;
            Fecha = DateTime.Now;
        }
    }
}
