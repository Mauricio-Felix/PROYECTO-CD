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
            OcultarControles1();
            OcultarControles2();

        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarControles1();
            if (cmbBusqueda.SelectedItem.Equals("Todos"))
            {
                dgvMostrarDatos.DataSource = pacientes.pacientes;
            }
            OcultarControles1();
            if (cmbBusqueda.SelectedItem.Equals("Número de Historia Clínica"))
            {
                lblNumClinica.Visible = true;
                mtxtClinica.Visible = true;
                btnMostrarHistoria.Visible = true;
            }
            if (cmbBusqueda.SelectedItem.Equals("Pacientes Tercera Edad"))
            {
                dgvMostrarDatos.DataSource = pacientes.TerceraEdad();
            }
            OcultarControles2();
            if(cmbBusqueda.SelectedItem.Equals("Nombre del Paciente"))
            {
                lblNomPaciente.Visible = true;
                mtxtNomPaciente.Visible = true;
                btnMostrarPaciente.Visible = true;
            }
        }
        public void OcultarControles1()
        {
            lblNumClinica.Visible = false;
            mtxtClinica.Visible = false;
            btnMostrarHistoria.Visible = false;
        }
        public void OcultarControles2()
        {
            lblNomPaciente.Visible = false;
            mtxtNomPaciente.Visible = false;
            btnMostrarPaciente.Visible = false;
        }
        private void btnMostrarHistoria_Click(object sender, EventArgs e)
        {
            dgvMostrarDatos.DataSource = pacientes.BuscarHistoria(Convert.ToInt32(mtxtClinica.Text));
            mtxtClinica.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMostrarPaciente_Click(object sender, EventArgs e)
        {
            dgvMostrarDatos.DataSource = pacientes.PacienteIniciaCadena(mtxtNomPaciente.Text);
            mtxtNomPaciente.Text = "";
        }
    }
}
