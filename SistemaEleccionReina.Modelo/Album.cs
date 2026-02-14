using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    internal class Album
    {
        public int Id { get; set; }
        public int IdCandidata { get; set; }
        public string NombreAlbum { get; set; }

        // Relación: un álbum tiene muchas fotos
        public List<Foto> Fotos { get; set; }

        public Album()
        {
            Fotos = new List<Foto>();
        }

        public Album(int idCandidata, string nombreAlbum)
        {
            IdCandidata = idCandidata;
            NombreAlbum = nombreAlbum;
            Fotos = new List<Foto>();
        }
    }
}
