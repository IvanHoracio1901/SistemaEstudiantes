using Datos;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logica
{
    public class LEstudiantes : libreria
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox imagen;
        private Bitmap _imagBitmap;
        private DataGridView _dataGridView;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            imagen = (PictureBox)objetos[0];

            _imagBitmap = (Bitmap)objetos[1];
            _dataGridView = (DataGridView)objetos[2];
            Restablecer();

        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El campo es requerido";
                listLabel[0].ForeColor = Color.Red;
                listLabel[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El campo es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listLabel[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El campo es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listLabel[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El campo es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listLabel[3].Focus();
                        }
                        else
                        {
                            if (textBoxEvent.comprobarFormatoemail(listTextBox[3].Text))
                            {
                                //Se hace una consulta para identificar si el email se encuentra en la bd con el metodo de Where e Equals para compararlo en toda la bd con el metodo Tolist
                                //que hace que toda la informacion la convierta en una lista
                                var comprobar = _estudiante.Where(u => u.Email.Equals(listTextBox[3].Text)).ToList();
                                
                                //Una vez comparado si no hay ninguna coincidencia se ejecuta el codigo para guardar
                                //Si no se muestra un mensaje
                                if (comprobar.Count.Equals(0))
                                {
                                    guardar();
                                }
                                else
                                {
                                    listLabel[3].Text = "Email ya registrado";
                                    listLabel[3].ForeColor = Color.Red;
                                    listLabel[3].Focus();
                                }
                                
                            }
                            else
                            {
                                listLabel[3].Text = "Email invalido";
                                listLabel[3].ForeColor = Color.Red;
                                listLabel[3].Focus();
                            }
                        }
                    }
                }
            }
        }
        public void guardar()
        {
            //Con BeginTransaction le estamos diciendo a la bd que se comenzará una transaccion de insercion de datos
            BeginTransactionAsync();
            try
            {
                var imagenArray = uploadImage.imageToByte(imagen.Image);
                //Se usa el objeto _estudiante para que la clase LEstudiante se pueda almacenar en la base de datos por medio de la clase Estudiante
                _estudiante.Value(e => e.NControl, listTextBox[0].Text)
                           .Value(e => e.Nombre, listTextBox[1].Text)
                           .Value(e => e.Apellido, listTextBox[2].Text)
                           .Value(e => e.Email, listTextBox[3].Text)
                           .Value(e => e.imagen, imagenArray)
                           .Insert();

                //Con CommitTransaction se esta accionando la insercion de datos
                CommitTransaction();
                //Limpia los registros
                Restablecer();
            }
            catch (Exception)
            {
                //Se revierte todo lo que se vaya a ejecutar en el try para insertar en las bd 
                RollbackTransaction();
            }
        }
        private int _num_pagina = 1, _reg_por_pagina = 2;
        public void BuscarEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if (campo.Equals(""))
            {
                //Crea una lista a partir del objeto estudiante
                query = _estudiante.ToList();
            }
            else
            {
                //Si hay algo en el campo, hace una busqueda por medio de Ncontrol o nombre o apellido
                query = _estudiante.Where(c => c.NControl.StartsWith(campo) || c.Nombre.StartsWith(campo) || c.Apellido.StartsWith(campo)).ToList();
            }
            if (0 < query.Count)
            {
                //Muestra los elementos que se encuentran en la lista en el datagrieview
                _dataGridView.DataSource = query.Select(c => new {
                    c.Id,
                    c.NControl,
                    c.Nombre,
                    c.Apellido,
                    c.Email
                    }).Skip(inicio).Take(_reg_por_pagina).ToList();
                _dataGridView.Columns[0].Visible = false;

                _dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                //Muestra el elemento a buscar
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.NControl,
                    c.Nombre,
                    c.Apellido,
                    c.Email
                }).ToList();
            }
        }
        public void Restablecer() 
        {
            imagen.Image = _imagBitmap;
            listLabel[0].Text = "NControl";
            listLabel[1].Text = "Nombres";
            listLabel[2].Text = "Apellido";
            listLabel[3].Text = "Email";

            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].ForeColor = Color.LightSlateGray;

            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";

            BuscarEstudiante("");
        }
    }
}
