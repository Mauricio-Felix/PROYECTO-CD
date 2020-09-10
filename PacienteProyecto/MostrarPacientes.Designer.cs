namespace PacienteProyecto
{
    partial class MostrarPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNumClinica = new System.Windows.Forms.Label();
            this.mtxtClinica = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarHistoria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarPaciente = new System.Windows.Forms.Button();
            this.lblNomPaciente = new System.Windows.Forms.Label();
            this.mtxtNomPaciente = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.Navy;
            this.lblBusqueda.Location = new System.Drawing.Point(483, 67);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(64, 15);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Mostrar: ";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Todos",
            "Número de Historia Clínica",
            "Pacientes Tercera Edad",
            "Nombre del Paciente"});
            this.cmbBusqueda.Location = new System.Drawing.Point(542, 64);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cmbBusqueda.TabIndex = 1;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(374, 142);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.Size = new System.Drawing.Size(552, 257);
            this.dgvMostrarDatos.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(979, 62);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNumClinica
            // 
            this.lblNumClinica.AutoSize = true;
            this.lblNumClinica.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClinica.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumClinica.Location = new System.Drawing.Point(6, 22);
            this.lblNumClinica.Name = "lblNumClinica";
            this.lblNumClinica.Size = new System.Drawing.Size(182, 17);
            this.lblNumClinica.TabIndex = 5;
            this.lblNumClinica.Text = " Número de Historia Clínica:";
            // 
            // mtxtClinica
            // 
            this.mtxtClinica.Location = new System.Drawing.Point(186, 22);
            this.mtxtClinica.Mask = "9999";
            this.mtxtClinica.Name = "mtxtClinica";
            this.mtxtClinica.Size = new System.Drawing.Size(92, 20);
            this.mtxtClinica.TabIndex = 7;
            this.mtxtClinica.ValidatingType = typeof(int);
            // 
            // btnMostrarHistoria
            // 
            this.btnMostrarHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarHistoria.Location = new System.Drawing.Point(186, 68);
            this.btnMostrarHistoria.Name = "btnMostrarHistoria";
            this.btnMostrarHistoria.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarHistoria.TabIndex = 9;
            this.btnMostrarHistoria.Text = "Mostrar";
            this.btnMostrarHistoria.UseVisualStyleBackColor = true;
            this.btnMostrarHistoria.Click += new System.EventHandler(this.btnMostrarHistoria_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtxtClinica);
            this.panel1.Controls.Add(this.lblNumClinica);
            this.panel1.Controls.Add(this.btnMostrarHistoria);
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 100);
            this.panel1.TabIndex = 11;
            // 
            // btnMostrarPaciente
            // 
            this.btnMostrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPaciente.Location = new System.Drawing.Point(144, 58);
            this.btnMostrarPaciente.Name = "btnMostrarPaciente";
            this.btnMostrarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPaciente.TabIndex = 17;
            this.btnMostrarPaciente.Text = "Mostrar";
            this.btnMostrarPaciente.UseVisualStyleBackColor = true;
            this.btnMostrarPaciente.Click += new System.EventHandler(this.btnMostrarPaciente_Click);
            // 
            // lblNomPaciente
            // 
            this.lblNomPaciente.AutoSize = true;
            this.lblNomPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPaciente.ForeColor = System.Drawing.Color.Indigo;
            this.lblNomPaciente.Location = new System.Drawing.Point(3, 22);
            this.lblNomPaciente.Name = "lblNomPaciente";
            this.lblNomPaciente.Size = new System.Drawing.Size(144, 17);
            this.lblNomPaciente.TabIndex = 13;
            this.lblNomPaciente.Text = "Nombre del Paciente: ";
            // 
            // mtxtNomPaciente
            // 
            this.mtxtNomPaciente.Location = new System.Drawing.Point(144, 22);
            this.mtxtNomPaciente.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNomPaciente.Name = "mtxtNomPaciente";
            this.mtxtNomPaciente.Size = new System.Drawing.Size(129, 20);
            this.mtxtNomPaciente.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNomPaciente);
            this.panel3.Controls.Add(this.btnMostrarPaciente);
            this.panel3.Controls.Add(this.mtxtNomPaciente);
            this.panel3.Location = new System.Drawing.Point(3, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 99);
            this.panel3.TabIndex = 18;
            // 
            // MostrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacienteProyecto.Properties.Resources.Imagen_Form_2;
            this.ClientSize = new System.Drawing.Size(1091, 471);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Name = "MostrarPacientes";
            this.Text = "MostrarPacientes";
            this.Load += new System.EventHandler(this.MostrarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumClinica;
        private System.Windows.Forms.MaskedTextBox mtxtClinica;
        private System.Windows.Forms.Button btnMostrarHistoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMostrarPaciente;
        private System.Windows.Forms.Label lblNomPaciente;
        private System.Windows.Forms.MaskedTextBox mtxtNomPaciente;
        private System.Windows.Forms.Panel panel3;
    }
}