﻿using Logica;
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

            Object[] objetos = { 
                pictureBoxEstudiante,
                Properties.Resources.baseline_add_a_photo_black_48dp,
                dataGridViewEstudiantes
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
    }
}
