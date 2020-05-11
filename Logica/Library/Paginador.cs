using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Logica.Library
{
    //Con la <T> se crea una clase generica
    public class Paginador <T>
    {
        private List<T> _dataList;
        private System.Windows.Forms.Label _label;
        //Se crea la variable static para que los valores no cambien en los procedimientos
        private static int maxReg, _reg_por_pagina, pageCount, numPage = 1;

        //se crea el constructor para inicializar las variables de esta clase
        public Paginador (List<T> dataList, System.Windows.Forms.Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _label = label;
            _reg_por_pagina = reg_por_pagina;
            CargarDatos();
        }
        private void CargarDatos()
        {
            numPage = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg / _reg_por_pagina);
            //Ajuste el numero de la pagina si la ultima pagina contiene una parte de la pagina
            if ((maxReg % _reg_por_pagina) > 0)
            {
                pageCount += 1;
            }
            _label.Text = $"Paginas 1 / {pageCount}";
        }

        public int primerPage()
        {
            numPage = 1;
            _label.Text = $"Paginas {numPage} / {pageCount}";
            return numPage;
        }

        public int pageAnterior()
        {
            if (numPage > 1)
            {
                numPage -= 1;
                _label.Text = $"Paginas {numPage} / {pageCount}";
            }
            return numPage;
        }
        public int SiguientePag()
        {
            if (numPage == pageCount)
                numPage -= 1;
            if (numPage < pageCount)
            {
                numPage += 1;
                _label.Text = $"Paginas {numPage} / {pageCount}";
            }
            return numPage;
        }
        public int ultimaPag()
        {
            numPage = pageCount;
            _label.Text = $"Paginas {numPage} / {pageCount}";
            return numPage;
        }
    }
}
