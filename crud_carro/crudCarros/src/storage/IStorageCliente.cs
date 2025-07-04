using Domain;
using System.Collections.Generic;

namespace Storage
{
   public interface IStorageCliente
   {
      int CadastrarCliente(Cliente cliente);
      Cliente ListarCliente(int id);
      List<Cliente> ListarClientes();
   }
}
