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
    public class CabeceraServices
    {
        readonly ICabeceraRepository cabeceraRepository;

        public CabeceraServices()
        {
            cabeceraRepository = new CabeceraRepository();
        }

        public IEnumerable<cabecera_prestamos> Getcabeceraprestamos()
        {
            return cabeceraRepository.GetAll();
        }

        public void Insertarcabeceraprestamos(cabecera_prestamos nuevacabeceraprestamos)
        {
            cabeceraRepository.add(nuevacabeceraprestamos);
        }

        public void Actualizarcabeceraprestamos(cabecera_prestamos nuevacabeceraprestamos)
        {
            cabeceraRepository.Modify(nuevacabeceraprestamos);
        }

        public void Eliminarcabeceraprestamos(int id)
        {
            cabeceraRepository.Delete(id);
        }

    }
}