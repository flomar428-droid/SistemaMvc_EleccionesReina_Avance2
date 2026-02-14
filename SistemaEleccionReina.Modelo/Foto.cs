using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    internal class Foto
    {
        public int Id { get; set; }
        public int IdAlbum { get; set; }
        public string RutaFoto { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        // Relación: una foto tiene muchos comentarios
        public List<Comentario> Comentarios { get; set; }

        public Foto()
        {
            Comentarios = new List<Comentario>();
        }

        public Foto(int idAlbum, string rutaFoto, string titulo, string descripcion)
        {
            IdAlbum = idAlbum;
            RutaFoto = rutaFoto;
            Titulo = titulo;
            Descripcion = descripcion;
            Comentarios = new List<Comentario>();
        }
    }
}
