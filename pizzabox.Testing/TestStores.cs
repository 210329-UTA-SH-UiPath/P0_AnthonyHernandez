namespace PizzaBox.Testing.Tests
{
   [Fact]
   public class TestStores
   {
      public void Test_StoreName()
      {
         var sut = new ChicagoStore();

         var actual = sut.Name;

         Assert.True(actual == "Chikagi Pizzeria");
      }
   }
}