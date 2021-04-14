using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
   public class PizzaTests
   {
      [Fact]
      public void Test_PizzaCrust()
      {
         // arrange
         var sut = new MeatPizza();

         // act
         var actual = sut.Crust;

         // assert
         Assert.Equal("Egg Crust", actual.Type);
      }
   }
}
