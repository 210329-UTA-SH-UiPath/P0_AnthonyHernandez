namespace Pizza.Logic.Abstracts
{
   /// <summary>
   /// A Pizza Part
   /// </summary>
   public abstract class AComponent
   {
      public short Id { get; set; }
      public string Name { get; set; }

      public decimal Price { get; set; }

   }
}