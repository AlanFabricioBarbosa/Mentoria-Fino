using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
   public interface ICarro
   {
      int CadastrarCarro(Carro carro);
      Carro ListarCarro(int id);
      List<Carro> ListarCarros();
   }
}
