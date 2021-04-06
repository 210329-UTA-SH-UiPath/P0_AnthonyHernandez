namespace pizzabox.Domain.Abstracts
{
   public abstract class A_Pizza
   {

      public enum Toppings
      {
         cheese, tomato_sauce, pepporoni,
         sasuage, bacon, mushrooms,
         alfredo_sauce, peppers, ham
      }

      public enum Size
      {
         Medium, Large, XtraLarge, MOBY
      }

      public enum Crust
      {
         Thin, Regular, Stuffed, Boneless
      }
   }
}