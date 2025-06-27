using Domain;
using Services.Interfaces;
using Storage.Interfaces;
using Storage.SQLite;
using System.Collections.Generic;

namespace Services
{
   public class ServicoCarro : ICarro
   {
      private readonly IStorageCarro _storage = new StorageCarroSQLite();

      public int CadastrarCarro(Carro carro)
      {
         return _storage.CadastrarCarro(carro);
      }

      public Carro ListarCarro(int id)
      {
         return _storage.ListarCarro(id);
      }

      public List<Carro> ListarCarros()
      {
         return _storage.ListarCarros();
      }
   }
}
