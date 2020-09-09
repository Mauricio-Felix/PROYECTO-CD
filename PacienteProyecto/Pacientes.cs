using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacienteProyecto
{
    public class Pacientes
    {
        public List<Paciente> pacientes { set; get; }
        public Pacientes()
        {
            pacientes = new List<Paciente>();
        }
        public void Agregar(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
        public List<Paciente> BuscarHistoria(int historia)
        {
            List<Paciente> persona = new List<Paciente>();
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.NumHistoriaClinica == historia)
                {
                    persona.Add(paciente);
                }
            }
            return persona;
        }
        public List<Paciente> TerceraEdad()
        {
            int edad = 65;
            List<Paciente> persona = new List<Paciente>();
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Edad >= edad)
                {
                    persona.Add(paciente);
                }
            }
            return persona;
        }
    }
}
