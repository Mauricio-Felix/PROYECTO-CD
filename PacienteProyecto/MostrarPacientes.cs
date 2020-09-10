using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacienteProyecto
{
    public partial class MostrarPacientes : Form
    {
        public Pacientes pacientes { set; get; }
        public MostrarPacientes()
        {
            InitializeComponent();
            pacientes = new Pacientes();
        }

        private void MostrarPacientes_Load(object sender, EventArgs e)
        {
            OcultarControles();
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarControles();
            if (cmbBusqueda.SelectedItem.Equals("Todos"))
            {

            }
        }

        
    }
}
