namespace Domain
{
   public enum TipoTransmissao { Manual = 0, Automatica, Automatizado, CVT, DSG }

   public class Carro
   {
      public int ID { get; set; }
      public MarcaCarro Marca { get; set; }
      public string Modelo { get; set; }
      public int AnoFabricação { get; set; }
      public int AnoModelo { get; set; }
      public int KM { get; set; }
      public TipoTransmissao Transmissao { get; set; }
      public float Valor { get; set; }
      public string Cor { get; set; }
      public string Chassis { get; set; }
      public HashSet<string> Opcionais { get; set; }
   }
}

