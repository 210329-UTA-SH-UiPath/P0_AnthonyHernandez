using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Client.Singletons;

namespace PizzaBox.Client
{
   internal class Program
   {
      private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
      private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance;
      private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;
      private static readonly StringSingleton _stringSingleton = StringSingleton.Instance;

      private static void Main(string[] args)
      {
         Run();
      }

      private static void Run()
      {
         var running = true;
         while (running)
         {
            DisplayMainMenu();
            var command = SelectMainMenuOption();
            switch (command)
            {
               case 1:
                  DisplayStores();
                  break;
               case 2:
                  DisplayOrders();
                  break;
               case 3:
                  CreateOrder();
                  break;
               case 4:
                  running = false;
                  break;
            }
         }
      }

      private static void DisplayMainMenu()
      {
         Console.WriteLine(_stringSingleton.Strings[0]);
      }

      private static void DisplayOrders()
      {
         foreach (Order order in _orderSingleton.Orders)
         {
            Console.WriteLine(order);
         }
      }

      private static void DisplayPizzas()
      {
         var index = 0;

         foreach (var item in _pizzaSingleton.Pizzas)
         {
            Console.WriteLine($"{++index} - {item}");
         }
      }

      private static void DisplayStores()
      {
         var index = 0;

         foreach (var item in _storeSingleton.Stores)
         {
            Console.WriteLine($"{++index} - {item}");
         }
      }

      private static int SelectMainMenuOption()
      {
         var input = int.Parse(Console.ReadLine()); // be careful (think execpetion/error handling)

         return input;
      }

      private static APizza SelectPizza()
      {
         var input = int.Parse(Console.ReadLine());
         var pizza = _pizzaSingleton.Pizzas[input - 1];
         return pizza;
      }

      private static AStore SelectStore()
      {
         var input = int.Parse(Console.ReadLine()); // be careful (think execpetion/error handling)
         return _storeSingleton.Stores[input - 1];
      }
      private static void CreateOrder()
      {
         DisplayCustomer();
         var customer = new Customer(Console.ReadLine());
         DisplayStores();
         DisplayList();
         var store = SelectStore();
         DisplayPizzas();
         DisplayList();
         var pizza = SelectPizza();
         _orderSingleton.Orders.Add(new Order(customer, store, pizza));
      }
      private static void DisplayCustomer()
      {
         Console.Write(_stringSingleton.Strings[2]);
      }
      private static void DisplayList()
      {
         Console.Write(_stringSingleton.Strings[3]);
      }
   }
}
