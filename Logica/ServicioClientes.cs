using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioClientes
    {
        RepositorioClientes Repositorio = new RepositorioClientes();
        public void Nuevo(Cliente cliente)
        {
            Repositorio.NuevoCliente(cliente);
        }
        public void Actualizar(Cliente cliente)
        {
            Repositorio.RegistrarOActualizarCliente(cliente);
        }

        public void Inactivar(int id)
        {
            Repositorio.Inactivar();
        }
        public void Activar(int id)
        {
            Repositorio.Activar();
        }
    }
}
