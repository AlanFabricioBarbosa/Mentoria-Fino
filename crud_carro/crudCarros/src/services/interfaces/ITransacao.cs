using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
   public interface IServicoTransacao
   {
      int InserirTransacao(TipoTransacao tipo, int clienteID, int carroID, DateTime data, float valor);
      Transacao ListarTransacao(int id);
      List<Transacao> ListarTransacoes(TipoTransacao tipo, int mes);
   }
}
