using Domain;
using Services.Interfaces;
using Storage;

namespace Services
{
   public class ServicoTransacao : IServicoTransacao
   {
      private readonly IStorageTransacao _storage;

      public ServicoTransacao(IStorageTransacao storage)
      {
         _storage = storage;
      }

      public int InserirTransacao(TipoTransacao tipo, int clienteID, int carroID, DateTime data, float valor)
      {
         var transacao = new Transacao
         {
            Tipo = tipo,
            ClienteID = clienteID,
            CarroID = carroID,
            Data = data,
            Valor = valor
         };
         return _storage.InserirTransacao(transacao);
      }

      public Transacao ListarTransacao(int id) => _storage.ListarTransacao(id);

      public List<Transacao> ListarTransacoes(TipoTransacao tipo, int mes) => _storage.ListarTransacoes(tipo, mes);
   }
}

