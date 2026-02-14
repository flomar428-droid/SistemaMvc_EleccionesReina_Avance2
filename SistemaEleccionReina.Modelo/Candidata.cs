using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    public class Candidata
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public string Pasatiempos { get; set; }
        public string Habilidades { get; set; }
        public string Intereses { get; set; }
        public string Aspiraciones { get; set; }
        public string FotoPrincipal { get; set; } // Ruta del archivo

        public Candidata() { }

        public Candidata(string nombre, string carrera, int edad)
        {
            Nombre = nombre;
            Carrera = carrera;
            Edad = edad;
        }
    }
}
