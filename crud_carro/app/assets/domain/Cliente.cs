using System;

namespace Domain
{
   public class Cliente
   {
      public int ID { get; set; }
      public string Nome { get; set; }
      public string Documento { get; set; }
      public ClienteContato[] Contato { get; set; }
      public string Logradouro { get; set; }
      public string CasaNumero { get; set; }
      public string Bairro { get; set; }
      public string Complemento { get; set; }
      public string Cidade { get; set; }
      public string Estado { get; set; }
      public int CEP { get; set; }
   }

   public class ClienteContato
   {
      public TipoContato Tipo { get; set; }
      public string Valor { get; set; }
   }
}
