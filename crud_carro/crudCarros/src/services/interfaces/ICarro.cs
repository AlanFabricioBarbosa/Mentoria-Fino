using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
   public interface IServicoCarro
   {
      int CadastrarCarro(Carro carro);
      Carro ListarCarro(int id);
      List<Carro> ListarCarros();
   }
}
