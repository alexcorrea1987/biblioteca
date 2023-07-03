using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class EmpleadoViewModel
    {
        public int Id_empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
