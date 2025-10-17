using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudADO
{
    public partial class FrmAgregar : Form
    {
        private Button btnGuardarAgregar;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;

        private void InitializeComponent()
        {
            btnGuardarAgregar = new Button();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnGuardarAgregar
            // 
            btnGuardarAgregar.Location = new Point(292, 175);
            btnGuardarAgregar.Name = "btnGuardarAgregar";
            btnGuardarAgregar.Size = new Size(94, 29);
            btnGuardarAgregar.TabIndex = 18;
            btnGuardarAgregar.Text = "Guardar";
            btnGuardarAgregar.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(103, 88);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(173, 27);
            txtEdad.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 16;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(46, 95);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 15;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre:";
            // 
            // FrmAgregar
            // 
            ClientSize = new Size(427, 235);
            Controls.Add(btnGuardarAgregar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmAgregar";
            ResumeLayout(false);
            PerformLayout();

        }


        public FrmAgregar() //constructor vacio
       {


           InitializeComponent();
       }

       public FrmAgregar(Persona persona) //constructor con parametro persona para editar
       {
           InitializeComponent();
           txtNombre.Text = persona.Nombre;
           txtEdad.Text = persona.Edad.ToString();
       }

       private void btnGuardarAgregar_Click(object sender, EventArgs e)
       {


           try
           {

               // 1. Capturar datos del formulario
               string nombre = txtNombre.Text;
               int edad = int.Parse(txtEdad.Text);

               // 2. Crear objeto Persona
               Persona persona = new Persona
               {
                   Nombre = nombre,
                   Edad = edad
               };

               // 3. Instanciar repositorio y guardar
               PersonaDB repositorioPersona = new PersonaDB();
               repositorioPersona.Agregar(persona);


               // 4. Indicar que la operación fue exitosa y cierra el forms
               this.Close();



           }


           catch (Exception ex)
           {
               MessageBox.Show("Error al guardar: " + ex.Message);
           }
       }
   
    }
}
