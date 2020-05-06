﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no dar saltos de linea cuando se oprime Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condicion que solo nos permite ingresar datos de tipo int
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no dar saltos de linea cuando se oprime Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //Condicion que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public bool comprobarFormatoemail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
