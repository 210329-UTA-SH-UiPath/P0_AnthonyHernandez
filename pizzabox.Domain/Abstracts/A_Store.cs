using pizzabox.Domain.Models;
using System.Xml.Serialization;

namespace pizzabox.Domain.Abstracts
{
   /// <summary>
   /// Represents the Store Abstract Class
   /// </summary>
   [XmlInclude(typeof(ChicagoStore))]
   [XmlInclude(typeof(NewYorkStore))]
   public class A_Store
   {
      public string Name { get; set; }

      protected A_Store()
      {

      }

      public override string ToString()
      {
         return $"{Name}";
      }
   }
}