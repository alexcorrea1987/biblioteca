using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class LibroViewModel
    {
        public int Id_libro { get; set; }
        public string Nombre_libros { get; set; }
        public string Nombre_editorial { get; set; }
        public string Codigo_editorial { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
