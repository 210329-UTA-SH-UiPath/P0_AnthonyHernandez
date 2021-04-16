using System;

namespace Pizza.UI
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var ctx = new OrderContext())
         {
            var pizza = new Pizza() { Name = "Pepperoni" };

            ctx.Pizzas.Add(pizza);
            ctx.SaveChanges();
         }
      }
   }
}
