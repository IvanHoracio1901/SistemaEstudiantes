using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("Conexion_2") { }
        public ITable<Estudiante> _estudiante { get { return GetTable<Estudiante>(); } }
    }
}
