using System.Collections.Generic;

namespace Pizza.Logic.Abstracts
{
   /// <summary>
   /// A Whole Pizza
   /// </summary>
   public abstract class APizza
   {
      public short Id { get; set; }
      public string Name { get; set; }
      public List<short?> ToppingsId { get; set; }
      public short? OrderId { get; set; }


   }
}