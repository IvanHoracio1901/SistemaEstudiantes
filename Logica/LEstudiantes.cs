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
        private NumericUpDown _numericUpDown;
        private Paginador<Estudiante> _paginador;
        private string _accion = "insertar";

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objetos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            imagen = (PictureBox)objetos[0];

            _imagBitmap = (Bitmap)objetos[1];
            _dataGridView = (DataGridView)objetos[2];
            _numericUpDown = (NumericUpDown)objetos[3];
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
                                    if (comprobar[0].Id.Equals(_idEstudiante))
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
                switch (_accion)
                {
                    case "insert":
                        //Se usa el objeto _estudiante para que la clase LEstudiante se pueda almacenar en la base de datos por medio de la clase Estudiante
                        _estudiante.Value(e => e.NControl, listTextBox[0].Text)
                                   .Value(e => e.Nombre, listTextBox[1].Text)
                                   .Value(e => e.Apellido, listTextBox[2].Text)
                                   .Value(e => e.Email, listTextBox[3].Text)
                                   .Value(e => e.imagen, imagenArray)
                                   .Insert();
                        break;
                    case "update":
                        _estudiante.Where(u => u.Id.Equals(_idEstudiante))
                                   .Set(e => e.NControl, listTextBox[0].Text)
                                   .Set(e => e.Nombre, listTextBox[1].Text)
                                   .Set(e => e.Apellido, listTextBox[2].Text)
                                   .Set(e => e.Email, listTextBox[3].Text)
                                   .Set(e => e.imagen, imagenArray)
                                   .Update();
                        break;


                }


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
                    c.Email,
                    c.imagen
                    }).Skip(inicio).Take(_reg_por_pagina).ToList();
                _dataGridView.Columns[0].Visible = false;
                _dataGridView.Columns[5].Visible = false;

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
        private int _idEstudiante = 0;
        public void GetEstudiante()
        {
            _accion = "update";
            _idEstudiante = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);

            try
            {
                byte[] arrayImage = (byte[])_dataGridView.CurrentRow.Cells[5].Value;
                imagen.Image = uploadImage.byteArrayToImage(arrayImage);
            }
            catch (Exception)
            {

                imagen.Image = _imagBitmap;
            }
        }
        private List<Estudiante> listEstudiante;
        public void Paginador(string metodo)
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _paginador.primerPage();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.pageAnterior();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.SiguientePag();
                    break;
                case "Ultima":
                    _num_pagina = _paginador.ultimaPag(); ;
                    break;

            }
            BuscarEstudiante("");
        }
        public void Registros_Paginas()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)_numericUpDown.Value;
            var list = _estudiante.ToList();

            if (0 < list.Count)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
                BuscarEstudiante("");
            }
        }
        public void Eliminar()
        {
            if (_idEstudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }
            else
            {
                if (MessageBox.Show("Estas seguro de eliminar al estudiante?","Eliminar estudiante",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _estudiante.Where(c => c.Id.Equals(_idEstudiante)).Delete();
                    Restablecer();
                }
            }
        }
        
        
        public void Restablecer() 
        {
            _accion = "insert";
            _num_pagina = 1;
            _idEstudiante = 0;
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

            listEstudiante = _estudiante.ToList();

            if (0 < listEstudiante.Count)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
            }

            BuscarEstudiante("");
        }
    }
}
