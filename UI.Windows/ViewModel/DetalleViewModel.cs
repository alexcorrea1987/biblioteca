using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class DetalleViewModel
    {
        public int Id_detalle_prestamos { get; set; }
        public Nullable<int> Id_libro { get; set; }
        public Nullable<int> Id_cab_prestamos { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
