using Domain;
using Services.Interfaces;
using Storage;

namespace Services
{
   public class ServicoCarro : IServicoCarro
   {
      private readonly IStorageCarro _storage;

      public ServicoCarro(IStorageCarro storage)
      {
         _storage = storage;
      }

      public int CadastrarCarro(Carro carro) => _storage.CadastrarCarro(carro);

      public Carro ListarCarro(int id) => _storage.ListarCarro(id);

      public List<Carro> ListarCarros() => _storage.ListarCarros();
   }
}

