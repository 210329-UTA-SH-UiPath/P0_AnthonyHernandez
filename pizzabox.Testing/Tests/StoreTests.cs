using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
   public class StoreTests
   {
      [Fact]
      public void Test_StoreName()
      {
         var sut = new ChicagoStore();

         var actual = sut.Name;

         Assert.True(actual == "Chicago Store");
      }
   }
}
