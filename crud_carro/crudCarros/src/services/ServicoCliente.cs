using Domain;
using Services.Interfaces;
using Storage;

namespace Services
{
   public class ServicoCliente : IServicoCliente
   {
      private readonly IStorageCliente _storage;

      public ServicoCliente(IStorageCliente storage)
      {
         _storage = storage;
      }

      public int CadastrarCliente(Cliente cliente) => _storage.CadastrarCliente(cliente);

      public Cliente ListarCliente(int id) => _storage.ListarCliente(id);

      public List<Cliente> ListarClientes() => _storage.ListarClientes();
   }
}

