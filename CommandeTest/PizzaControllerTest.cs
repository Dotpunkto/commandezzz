using System.Net;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using commandezzz.Controllers;
using commandezzz.IServices;
using System.Web.Http;
using commandezzz.Model;
using System.Collections.Generic;
using MyTested.WebApi;

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
