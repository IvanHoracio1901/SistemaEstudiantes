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
        private LEstudiantes estudiantes;
        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNControl);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);

            var listLabel = new List<Label>();
            listLabel.Add(labelNControl);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            listLabel.Add(labelPaginador);

            Object[] objetos = { 
                pictureBoxEstudiante,
                Properties.Resources.baseline_add_a_photo_black_48dp,
                dataGridViewEstudiantes,
                numericUpDown1
            };

            estudiantes = new LEstudiantes(listTextBox, listLabel, objetos);
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
            estudiantes.textBoxEvent.numberKeyPress(e);
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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            estudiantes.BuscarEstudiante(textBoxBuscar.Text);
        }

        private void buttonPrimeraPag_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Primero");
        }

        private void buttonAnteriorPag_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Anterior");
        }

        private void buttonSigPag_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Siguiente");
        }

        private void buttonUltimaPag_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Ultima");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiantes.Registros_Paginas();
        }

        private void dataGridViewEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEstudiantes.Rows.Count != 0)
            {
                estudiantes.GetEstudiante();
            }
        }

        private void dataGridViewEstudiantes_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewEstudiantes.Rows.Count != 0)
            {
                estudiantes.GetEstudiante();
            }
        }
    }
}
