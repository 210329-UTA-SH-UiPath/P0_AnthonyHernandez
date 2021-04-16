using System;

namespace Pizza.Storage.Entities
{
   public class OrderContext : DbContext
   {
      public OrderContext() : base()
      {

      }

      public DbSet<Pizza> Pizzas { get; set; }
      public Dbset<Store> Stores { get; set; }
   }
}
