using Domain;
using Microsoft.Data.Sqlite;
using Storage;
using System.Collections.Generic;

namespace Storage.Sqlite
{
   public class StorageCarroSQLite : IStorageCarro
   {
      private readonly SqliteConnection _conn;

      public StorageCarroSQLite()
      {
         _conn = new SqliteConnection("Data Source=loja.db");
         _conn.Open();
      }

      public int CadastrarCarro(Carro carro)
      {
         var sql = "INSERT INTO Carros (Marca, Modelo, AnoFabricação, AnoModelo, KM, Transmissao, Valor, Cor, Chassis) " +
                     "VALUES (@Marca, @Modelo, @AnoF, @AnoM, @KM, @Transmissao, @Valor, @Cor, @Chassis)";
            using var cmd = _conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Marca", (int)carro.Marca);
            cmd.Parameters.AddWithValue("@Modelo", carro.Modelo);
            cmd.Parameters.AddWithValue("@AnoF", carro.AnoFabricação);
            cmd.Parameters.AddWithValue("@AnoM", carro.AnoModelo);
            cmd.Parameters.AddWithValue("@KM", carro.KM);
            cmd.Parameters.AddWithValue("@Transmissao", (int)carro.Transmissao);
            cmd.Parameters.AddWithValue("@Valor", carro.Valor);
            cmd.Parameters.AddWithValue("@Cor", carro.Cor);
            cmd.Parameters.AddWithValue("@Chassis", carro.Chassis);
         return cmd.ExecuteNonQuery();
      }

      public Carro ListarCarro(int id) => throw new NotImplementedException();
      public List<Carro> ListarCarros() => throw new NotImplementedException();
   }
}
