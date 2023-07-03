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
    public class ClienteServices
    {
        readonly IClienteRepository clienteRepository;

        public ClienteServices ()
        {
            clienteRepository = new ClienteRepository();
        }

        public IEnumerable<cliente> Getcliente()
        {
            return clienteRepository.GetAll();
        }

        public void Insertarcliente(cliente nuevocliente)
        {
            clienteRepository.add(nuevocliente);
        }

        public void Actualizarcliente(cliente nuevocliente)
        {
            clienteRepository.Modify(nuevocliente);
        }

        public void Eliminarcliente (int id)
        {
            clienteRepository.Delete(id);
        }

    }
}
