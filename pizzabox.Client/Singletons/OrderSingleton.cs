using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Singletons
{
   public class OrderSingleton
   {
      private static OrderSingleton _instance;
      private static readonly FileRepository _fileRepository = new FileRepository();
      private const string _path = @"order.xml";
      public List<Order> Orders { get; set; }
      public static OrderSingleton Instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new OrderSingleton();
            }

            return _instance;
         }
      }

      private OrderSingleton()
      {
         Orders = new List<Order>();
      }
      public bool Save()
      {
         return _fileRepository.WriteToFile<Order>(_path, Orders);
      }
      public void AddOrder(Order order)
      {
         ShowOrders();
         Orders.Add(order);
         ShowOrders();
      }
      public void ShowOrders()
      {
         foreach (Order order in Orders)
         {
            Console.WriteLine(order);
         }
      }
   }
}
