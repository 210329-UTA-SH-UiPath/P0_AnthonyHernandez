using pizzabox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
   public class TestStores
   {
      [Fact]
      public void Test_StoreName()
      {
         //arrange
         var sut = new ChicagoStore();
         //act
         var actual = sut.Name;
         //assert
         Assert.True(actual == "Chikagi Pizzeria");
      }
   }
}