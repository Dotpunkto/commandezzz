using Microsoft.VisualStudio.TestTools.UnitTesting;
using commandezzz.IServices;

namespace CommandeTest
{
    [TestClass]
    public class PizzaControllerTest
    {
        public IPizzaService _pizzaService;

        public PizzaControllerTest(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [TestMethod]
        public void GetAllTest()
        {
            // MyWebApi.Routes()
            //         .ShouldMap("api/Pizzas/GetAll")
            //         .ToNonExistingRoute();
        }
    }
}
