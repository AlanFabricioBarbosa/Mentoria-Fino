using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
   public interface IServicoCliente
   {
      int CadastrarCliente(Cliente cliente);
      Cliente ListarCliente(int id);
      List<Cliente> ListarClientes();
   }
}
