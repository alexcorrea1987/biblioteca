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
    public class EmpleadoServices
    {
        readonly IEmpleadoRepository empleadoRepository;

        public EmpleadoServices()
        {
            empleadoRepository = new EmpleadoRepository();
        }

        public IEnumerable<empleado> Getempleado()
        {
            return empleadoRepository.GetAll();
        }

        public void Insertarempleado(empleado nuevoempleado)
        {
            empleadoRepository.add(nuevoempleado);
        }

        public void Actualizarempleado(empleado nuevoempleado)
        {
            empleadoRepository.Modify(nuevoempleado);
        }

        public void Eliminarempleado(int id)
        {
            empleadoRepository.Delete(id);
        }

    }
}
