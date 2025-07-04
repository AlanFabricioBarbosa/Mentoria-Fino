using Domain;
using System.Collections.Generic;

namespace Storage
{
   public interface IStorageCarro
   {
      int CadastrarCarro(Carro carro);
      Carro ListarCarro(int id);
      List<Carro> ListarCarros();
   }
}


