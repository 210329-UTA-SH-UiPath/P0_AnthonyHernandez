using PizzaBox.Domain.Abstracts;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Models
{

   [XmlInclude(typeof(Customer))]
   [XmlInclude(typeof(APizza))]
   [XmlInclude(typeof(AStore))]
   [XmlInclude(typeof(MeatPizza))]
   [XmlInclude(typeof(VeganPizza))]
   public class Order
   {
      public AStore Store { get; set; }
      public Customer Customer { get; set; }
      public APizza Pizza { get; set; }
      public Order(Customer customer, AStore store, APizza pizza)
      {
         Customer = customer;
         Store = store;
         Pizza = pizza;
      }
      public override string ToString()
      {
         return $"{Store} {Customer} {Pizza}";
      }
   }
}
