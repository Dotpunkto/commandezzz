using System;
using System.Collections.Generic;
using commandezzz.Model;
using Microsoft.AspNetCore.Mvc;
using commandezzz.IServices;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace commandezzz.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PizzasController : System.Web.Http.ApiController
    {
        public IPizzaService _pizzaService;

        public PizzasController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        [Route("/")]
        public string index()
        {
            return "coucou";
        }

        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return _pizzaService.GetPizza(id);
        }

        [HttpGet]
        public List<Pizza> GetAll()
        {
            return _pizzaService.GetAllPizza();
        }

        [HttpPost]
        public void Post([FromBody] Pizza pizza)
        {
            _pizzaService.AddPizza(pizza);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pizzaService.DeletePizza(id);
        }
    }
}
