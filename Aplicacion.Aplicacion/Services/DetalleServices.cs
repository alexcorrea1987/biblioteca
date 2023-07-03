using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class DetalleServices
    {
        readonly IDetalleRepository detalleRepository;

        public DetalleServices ()
        {
            detalleRepository = new DetalleRepository();
        }

        public IEnumerable<detalle_prestamos> Getdetalleprestamos()
        {
            return detalleRepository.GetAll();
        }

        public void Insertardetalleprestamos(detalle_prestamos nuevodetalleprestamos)
        {
            detalleRepository.add(nuevodetalleprestamos);
        }

        public void Actualizardetalleprestamos(detalle_prestamos nuevodetalleprestamos)
        {
            detalleRepository.Modify(nuevodetalleprestamos);
        }

        public void Eliminardetalleprestamos(int id)
        {
            detalleRepository.Delete(id);
        }

    }
}
