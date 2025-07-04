using Domain;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Storage.Sqlite
{
   public class StorageTransacaoSQLite : IStorageTransacao
   {
      private readonly SqliteConnection _conn;

      public StorageTransacaoSQLite()
      {
         _conn = new SqliteConnection("Data Source=loja.db");
         _conn.Open();
      }

      public int InserirTransacao(Transacao transacao)
      {
         var sql = "INSERT INTO Transacoes (Tipo, CarroID, ClienteID, Valor, Data) " +
                     "VALUES (@Tipo, @CarroID, @ClienteID, @Valor, @Data)";
            using var cmd = _conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Tipo", (int)transacao.Tipo);
            cmd.Parameters.AddWithValue("@CarroID", transacao.CarroID);
            cmd.Parameters.AddWithValue("@ClienteID", transacao.ClienteID);
            cmd.Parameters.AddWithValue("@Valor", transacao.Valor);
            cmd.Parameters.AddWithValue("@Data", transacao.Data.ToString("yyyy-MM-dd"));
         return cmd.ExecuteNonQuery();
      }

      public Transacao ListarTransacao(int id) => throw new NotImplementedException();
      public List<Transacao> ListarTransacoes(TipoTransacao tipo, int mes) => throw new NotImplementedException();
   }
}
