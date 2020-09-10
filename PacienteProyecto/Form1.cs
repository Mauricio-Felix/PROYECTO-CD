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
    public partial class frmRegistro : Form
    {
        Pacientes personas = new Pacientes();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                if(VerificarInformacion())
                {
                    Paciente persona = new Paciente();
                    persona.Nombre = mtxtNombres.Text;
                    persona.Apellido = mtxtApellidos.Text;
                    persona.CI = txtCedula.Text;
                    persona.Edad = Convert.ToInt32(mtxtEdad.Text);
                    persona.FechaNacimiento = dtpFechaNacimiento.Value.ToString();
                    persona.NumHistoriaClinica = Convert.ToInt32(mtxtNumHistoria.Text);
                    persona.NumSala = Convert.ToInt32(mtxtSala.Text);
                    persona.Genero = cmbGenero.Text;
                    personas.Agregar(persona);
                    MessageBox.Show("Datos guardados correctamente");
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Ingrese toda la informacion");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public bool VerificarInformacion()
        {
            bool verificar = false;
            if(mtxtApellidos.Text!=""&& mtxtNombres.Text!=""&& mtxtEdad.Text!=""&& mtxtNumHistoria.Text!=""&& mtxtSala.Text!=""&& txtCedula.Text!=""  )
            {
                verificar = true;
            }
            return verificar;
        }
        public void LimpiarControles()
        {
            mtxtApellidos.Text = "";
            mtxtNombres.Text = "";
            mtxtEdad.Text = "";
            mtxtNumHistoria.Text = "";
            mtxtSala.Text = "";
            txtCedula.Text = "";
            cmbGenero.SelectedValue = false;
            dtpFechaNacimiento.Value = DateTime.Now;
        }
    }
}
