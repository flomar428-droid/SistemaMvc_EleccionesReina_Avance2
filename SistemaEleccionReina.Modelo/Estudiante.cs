using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEleccionReina.Modelo
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }

        public Estudiante() { }

        public Estudiante(string matricula, string nombre)
        {
            Matricula = matricula;
            Nombre = nombre;
        }
    }
}
