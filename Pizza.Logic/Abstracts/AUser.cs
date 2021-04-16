namespace Pizza.Logic.Abstracts
{
   /// <summary>
   /// Someone who is intereacting
   /// </summary>
   public abstract class AUser
   {
      public short Id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }

   }
}