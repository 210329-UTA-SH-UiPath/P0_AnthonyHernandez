using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
   public class VeganPizza : APizza
   {
      public VeganPizza()
      {
         Type = "Vegan Pizza";
      }
      public override void AddCrust()
      {
         Crust = new Crust("Lettuce");
      }

      public override void AddSize()
      {
         Size = null;
      }

      public override void AddToppings()
      {
         Toppings.AddRange(new Topping[] { new Topping(), new Topping() });
      }
   }
}
