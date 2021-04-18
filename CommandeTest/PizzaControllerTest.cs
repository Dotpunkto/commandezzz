using commandezzz.Controllers;
using commandezzz.Model;
using Microsoft.Extensions.Configuration;
using Xunit;
using commandezzz.IServices;
using System.Collections.Generic;
using Moq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CommandeTest
{
    public class PizzaControllerTest
    {

        [Fact]
        public void Test1Async()
        {
            // Arrange
            var pizzaService = new Mock<IPizzaService>();
            pizzaService.Setup(x => x.GetAllPizza())
                .Returns(new List<Pizza>());

            var controller = new PizzasController(pizzaService.Object);

            // Act
            IHttpActionResult actionResult = controller.GetAll();
            var contentResult = actionResult as OkNegotiatedContentResult<List<Pizza>>;

            // Assert
            Assert.NotNull(contentResult);
            Assert.NotNull(contentResult.Content);
        }
    }
}
