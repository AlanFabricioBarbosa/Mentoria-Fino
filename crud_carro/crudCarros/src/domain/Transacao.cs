namespace Domain
{
   public enum TipoTransacao { Compra = 0, Venda }

   public class Transacao
   {
      public int ID { get; set; }
      public TipoTransacao Tipo { get; set; }
      public int CarroID { get; set; }
      public int ClienteID { get; set; }
      public float Valor { get; set; }
      public DateTime Data { get; set; }
   }
}

