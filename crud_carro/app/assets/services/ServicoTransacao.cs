using Domain;
using Services.Interfaces;
using Storage.Interfaces;
using Storage.SQLite;
using System;
using System.Collections.Generic;

namespace Services
{
   public class ServicoTransacao : ITransacao
   {
      private readonly IStorageTransacao _storage = new StorageTransacaoSQLite();

      public List<Transacao> ListarTransacoes(TipoTransacao tipo, int mes)
      {
         return _storage.ListarTransacoes(tipo, mes);
      }

      public Transacao ListaTransacao(int id)
      {
         return _storage.ListarTransacao(id);
      }

      public int InsereTransacao(TipoTransacao tipo, int clienteID, int carroID, DateTime data, float valor)
      {
         return _storage.InsereTransacao(tipo, clienteID, carroID, data, valor);
      }
   }
}
