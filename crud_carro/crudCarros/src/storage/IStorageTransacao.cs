using Domain;
using System.Collections.Generic;

namespace Storage
{
   public interface IStorageTransacao
   {
      int InserirTransacao(Transacao transacao);
      Transacao ListarTransacao(int id);
      List<Transacao> ListarTransacoes(TipoTransacao tipo, int mes);
   }
}
