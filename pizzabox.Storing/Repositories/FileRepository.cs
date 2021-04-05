using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using pizzabox.Domain.Abstracts;
using System;

namespace pizzabox.Storing.Repositories
{
   public class FileRepository
   {
      public bool WriteToFile(List<A_Store> stores)
      {
         try
         {
            // access to path
            string path = @"store.xml"; // literal string using @ (Ignore special Char)
            // open file
            StreamWriter writer = new StreamWriter(path);
            // access to object
            // class definition (structure)
            XmlSerializer xml = new XmlSerializer(typeof(List<A_Store>));
            // serialize (convert to markup) to xml
            xml.Serialize(writer, stores);
            // write to file
            // close file
            return true;
         }
         // catch (FileNotFoundException e)
         // {
         //    throw new Exception("Incorrect file", e);
         // }
         catch (Exception e)
         {
            return false;
         }
      }

      public List<T> ReadFromFile<T>(string path) where T : class
      {
         var reader = new StreamReader(path);
         var xml = new XmlSerializer(typeof(List<T>));

         return xml.Deserialize(reader) as List<T>;
      }
   }
}