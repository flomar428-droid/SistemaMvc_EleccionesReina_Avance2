using System;
using System.Windows.Forms;
using SistemaEleccionReina.Datos;
using SistemaEleccionReina.Modelo;

namespace SistemaMvc_EleccionesReina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CandidataRepositorio repo = new CandidataRepositorio();

                Candidata nueva = new Candidata
                {
                    Nombre = "Maria Perez",
                    Carrera = "Ingeniería",
                    Edad = 21,
                    Pasatiempos = "Leer",
                    Habilidades = "Oratoria",
                    Intereses = "Tecnología",
                    Aspiraciones = "Ser Líder",
                    FotoPrincipal = "foto1.jpg"
                };

                repo.Insertar(nueva);

                var lista = repo.ObtenerTodas();

                MessageBox.Show("Total candidatas: " + lista.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
