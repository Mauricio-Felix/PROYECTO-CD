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
            this.lblSala = new System.Windows.Forms.Label();
            this.mtxtClinica = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSala = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarHistoria = new System.Windows.Forms.Button();
            this.btnMostrarSala = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.Navy;
            this.lblBusqueda.Location = new System.Drawing.Point(467, 15);
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
            "Número de Sala",
            "Pacientes Tercera Edad"});
            this.cmbBusqueda.Location = new System.Drawing.Point(526, 12);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 21);
            this.cmbBusqueda.TabIndex = 1;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(354, 96);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.Size = new System.Drawing.Size(552, 257);
            this.dgvMostrarDatos.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(851, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblNumClinica
            // 
            this.lblNumClinica.AutoSize = true;
            this.lblNumClinica.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClinica.ForeColor = System.Drawing.Color.Indigo;
            this.lblNumClinica.Location = new System.Drawing.Point(6, 22);
            this.lblNumClinica.Name = "lblNumClinica";
            this.lblNumClinica.Size = new System.Drawing.Size(227, 17);
            this.lblNumClinica.TabIndex = 5;
            this.lblNumClinica.Text = "Ingrese Número de Historia Clínica:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Indigo;
            this.lblSala.Location = new System.Drawing.Point(6, 31);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(158, 17);
            this.lblSala.TabIndex = 6;
            this.lblSala.Text = "Ingrese Número de Sala:";
            // 
            // mtxtClinica
            // 
            this.mtxtClinica.Location = new System.Drawing.Point(232, 19);
            this.mtxtClinica.Mask = "99999";
            this.mtxtClinica.Name = "mtxtClinica";
            this.mtxtClinica.Size = new System.Drawing.Size(100, 20);
            this.mtxtClinica.TabIndex = 7;
            this.mtxtClinica.ValidatingType = typeof(int);
            // 
            // mtxtSala
            // 
            this.mtxtSala.Location = new System.Drawing.Point(163, 28);
            this.mtxtSala.Mask = "99";
            this.mtxtSala.Name = "mtxtSala";
            this.mtxtSala.Size = new System.Drawing.Size(100, 20);
            this.mtxtSala.TabIndex = 8;
            this.mtxtSala.ValidatingType = typeof(int);
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
            this.btnMostrarHistoria.Click += new System.EventHandler(this.btnMostrarHistoria_Click);
            // 
            // btnMostrarSala
            // 
            this.btnMostrarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSala.Location = new System.Drawing.Point(154, 71);
            this.btnMostrarSala.Name = "btnMostrarSala";
            this.btnMostrarSala.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarSala.TabIndex = 10;
            this.btnMostrarSala.Text = "Mostrar";
            this.btnMostrarSala.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtxtClinica);
            this.panel1.Controls.Add(this.lblNumClinica);
            this.panel1.Controls.Add(this.btnMostrarHistoria);
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtxtSala);
            this.panel2.Controls.Add(this.lblSala);
            this.panel2.Controls.Add(this.btnMostrarSala);
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 100);
            this.panel2.TabIndex = 12;
            // 
            // MostrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacienteProyecto.Properties.Resources.Imagen_Form_2;
            this.ClientSize = new System.Drawing.Size(938, 468);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNumClinica;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.MaskedTextBox mtxtClinica;
        private System.Windows.Forms.MaskedTextBox mtxtSala;
        private System.Windows.Forms.Button btnMostrarHistoria;
        private System.Windows.Forms.Button btnMostrarSala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}