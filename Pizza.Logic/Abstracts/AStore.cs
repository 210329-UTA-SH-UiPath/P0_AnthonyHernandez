namespace Pizza.Logic.Abstracts
{
   /// <summary>
   /// A Store that exist
   /// </summary>
   public abstract class AStore
   {
      public short Id { get; set; }
      public string Name { get; set; }

      protected AStore()
      {

      }

      /// <summary>
      /// Converts AStore to String
      /// </summary>
      /// <returns></returns>
      public override string ToString()
      {
         return $"{Name}";
      }
   }
}