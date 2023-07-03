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
    public class LibroServices
    {
        readonly ILibroRepository libroRepository;

        public LibroServices()
        {
            libroRepository = new LibroRepository();
        }

        public IEnumerable<libro> Getlibro()
        {
            return libroRepository.GetAll();
        }

        public void Insertarlibro(libro nuevolibro)
        {
            libroRepository.add(nuevolibro);
        }

        public void Actualizarlibro(libro nuevolibro)
        {
            libroRepository.Modify(nuevolibro);
        }

        public void Eliminarlibro(int id)
        {
            libroRepository.Delete(id);
        }

    }
}
