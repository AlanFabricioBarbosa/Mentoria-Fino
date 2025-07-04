using Domain;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Storage.Sqlite
{
   public class StorageClienteSQLite : IStorageCliente
   {
      private readonly SqliteConnection _conn;

      public StorageClienteSQLite()
      {
         _conn = new SqliteConnection("Data Source=loja.db");
         _conn.Open();
      }

      public int CadastrarCliente(Cliente cliente)
      {
         var sql = "INSERT INTO Clientes (Nome, Documento, Logradouro, CasaNumero, Bairro, Complemento, Cidade, Estado, CEP) " +
                     "VALUES (@Nome, @Documento, @Logradouro, @CasaNumero, @Bairro, @Complemento, @Cidade, @Estado, @CEP)";
            using var cmd = _conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
            cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@CasaNumero", cliente.CasaNumero);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
         return cmd.ExecuteNonQuery();
      }

      public Cliente ListarCliente(int id) => throw new NotImplementedException();
      public List<Cliente> ListarClientes() => throw new NotImplementedException();
   }
}
