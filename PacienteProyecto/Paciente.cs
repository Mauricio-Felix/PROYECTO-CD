using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacienteProyecto
{
    public class Paciente
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Edad { set; get; }
        public string FechaNacimiento { set; get; }
        public string CI { set; get; }
        public string Genero { set; get; }
        public int NumHistoriaClinica { set; get; }
        public int NumSala { set; get; }

        public Paciente()
        {

        }

        public Paciente(string nombre, string apellido, int edad, string fechaNacimiento, string cI, string genero, int numHistoriaClinica, int numSala)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            FechaNacimiento = fechaNacimiento;
            CI = cI;
            Genero = genero;
            NumHistoriaClinica = numHistoriaClinica;
            NumSala = numSala;
        }
    }
}
