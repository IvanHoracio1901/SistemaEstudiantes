﻿using LinqToDB;
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

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            imagen = (PictureBox)objetos[0];
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
                                var imagenArray = uploadImage.imageToByte(imagen.Image);
                                //Se usa el objeto _estudiante para que la clase LEstudiante se pueda almacenar en la base de datos por medio de la clase Estudiante
                                _estudiante.Value(e => e.NControl, listTextBox[0].Text)
                                           .Value(e => e.Nombre, listTextBox[1].Text)
                                           .Value(e => e.Apellido, listTextBox[2].Text)
                                           .Value(e => e.Email, listTextBox[3].Text)
                                           .Insert();
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
    }
}
