using pizzabox.Domain.Abstracts;

namespace pizzabox.Domain.Models
{
   public class Order
   {
      public A_Store Store { get; set; }
      public Customer Customer { get; set; }
      public A_Pizza Pizza { get; set; }

      public void Save()
      {

      }
   }
}