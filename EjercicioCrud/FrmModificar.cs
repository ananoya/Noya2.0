using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudADO
{
    public partial class FrmModificar : Form
    {
        public FrmModificar(Persona persona) //constructor con parametro persona para editar
        {
            InitializeComponent();
            txtId.Text = persona.Id.ToString();
            txtNombre.Text = persona.Nombre;
            txtEdad.Text = persona.Edad.ToString();
        }
        private void FrmModificar_Load_1(object sender, EventArgs e)
        {
            txtId.Enabled = false;

        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                int id = int.Parse(txtId.Text);

                Persona persona = new Persona //respetar la query
                {

                    Nombre = nombre,
                    Edad = edad,
                    Id = id
                };

                PersonaDB repositorio = new PersonaDB();
                repositorio.Modificar(persona);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }

        

        private void InitializeComponent()
        {
            btnGuardarModificar = new System.Windows.Forms.Button();
            label1 = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            txtId = new System.Windows.Forms.TextBox();
            txtEdad = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnGuardarModificar
            // 
            btnGuardarModificar.Location = new Point(296, 201);
            btnGuardarModificar.Name = "btnGuardarModificar";
            btnGuardarModificar.Size = new Size(94, 29);
            btnGuardarModificar.TabIndex = 19;
            btnGuardarModificar.Text = "Guardar";
            btnGuardarModificar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 46);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 22;
            label1.Text = "Id:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(83, 131);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 21;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(145, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 27);
            txtId.TabIndex = 25;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(145, 124);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(173, 27);
            txtEdad.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 23;
            txtNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmModificar
            // 
            ClientSize = new Size(511, 289);
            Controls.Add(txtId);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardarModificar);
            Name = "FrmModificar";
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.Button btnGuardarModificar;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Label label1;
        private Label lblEdad;
        private Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
