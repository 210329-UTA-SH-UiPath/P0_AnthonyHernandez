using System;
using System.Collections.Generic;

namespace Pizza.Logic.Models
{
   public class Order
   {
      public short Id { get; set; }
      public short CustomerId { get; set; }
      public short StoreId { get; set; }
      public decimal TotalPrice { get; set; }
      public DateTime OrderDate { get; set; }

      public ICollection<Pizza> Pizzas { get; set; }



   }
}