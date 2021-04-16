using commandezzz.Controllers;
using commandezzz.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Pizzas _controller;
        public UnitTest1(PizzaService pizzaService)
        {
            _controller = new Pizzas(pizzaService);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var response = _controller.GetAll();
            //response.
        }
    }
}
