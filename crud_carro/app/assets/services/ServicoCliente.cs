using Domain;
using Services.Interfaces;
using Storage.Interfaces;
using Storage.SQLite;
using System.Collections.Generic;

namespace Services
{
   public class ServicoCliente : ICliente
   {
      private readonly IStorageCliente _storage = new StorageClienteSQLite();

      public int CadastrarCliente(Cliente cliente)
      {
         return _storage.CadastrarCliente(cliente);
      }

      public Cliente ListarCliente(int id)
      {
         return _storage.ListarCliente(id);
      }

      public List<Cliente> ListarClientes()
      {
         return _storage.ListarClientes();
      }
   }
}
