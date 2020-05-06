using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiantes = new LEstudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxEstudiante_Click(object sender, EventArgs e)
        {
            estudiantes.uploadImage.CargarImagen(pictureBoxEstudiante);
        }

        private void textBoxNControl_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNControl.Text.Equals(""))
            {
                labelNControl.ForeColor = Color.LightSlateGray;

            }
            else
            {
                labelNControl.ForeColor = Color.Green;
                labelNControl.Text = "NControl";
            }
        }

        private void textBoxNControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNControl.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;

            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNControl.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;

            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNControl.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;

            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
