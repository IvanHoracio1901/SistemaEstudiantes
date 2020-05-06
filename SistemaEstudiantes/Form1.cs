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
            estudiantes.CargarImagen(pictureBoxEstudiante);
        }
    }
}
