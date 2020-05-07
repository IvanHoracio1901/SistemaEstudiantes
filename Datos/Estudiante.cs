using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Estudiante
    {
        [PrimaryKey, Identity]
        public int Id { set; get; }
        public string NControl { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public byte[] imagen { set; get; }
    }
}
