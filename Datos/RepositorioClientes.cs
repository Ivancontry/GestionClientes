using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioClientes : Conexion
    {
        List<Cliente> lista = new List<Cliente>();
        private DataTable dataTable = new DataTable();

        public new MySqlCommand Cmd { get; set; }

        public void NuevoCliente(Cliente cliente)
        {
            RegistrarOActualizarCliente(cliente);
        }

        public String RegistrarOActualizarCliente(Cliente cliente)
        {
            try
            {
                if (Conectar())
                {
                    MySqlTransaction transaction = Connection.BeginTransaction();

                    Cmd = new MySqlCommand("RegistrarOActualizarCliente", Connection, transaction)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    Cmd.Parameters.Add(new MySqlParameter("identificacion", cliente.Identificacion));
                    Cmd.Parameters.Add(new MySqlParameter("nombre", cliente.Nombre));
                    Cmd.Parameters.Add(new MySqlParameter("direccion", cliente.Direccion));
                    Cmd.Parameters.Add(new MySqlParameter("telefono", cliente.Telefono));
                    Cmd.Parameters.Add(new MySqlParameter("edad", cliente.Telefono));
                    Cmd.Parameters.Add(new MySqlParameter("salario", cliente.Telefono));
                    Cmd.Parameters.Add(new MySqlParameter("estado", cliente.Estado));

                    if (Cmd.ExecuteNonQuery() >= 0)
                    {
                        transaction.Commit();
                        return "exito";
                    }
                    else
                    {
                        return "Error";
                    }
                }
                else
                {
                    return "Error Conectar Base Datos";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                DesConectar();
            }
        }

        public void Activar()
        {
            throw new NotImplementedException();
        }

        public void Inactivar()
        {
            throw new NotImplementedException();
        }
    }
}
