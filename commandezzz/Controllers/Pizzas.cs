using System.Collections.Generic;
using System;
using commandezzz.DataAccess;
using commandezzz.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace commandezzz.Controllers
{
    [Route("api/[controller]/[action]")]
    public class Pizzas : Controller
    {
        public CommandeContext _Context;

        public Pizzas(CommandeContext context)
        {
            _Context = context;
        }

        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return _Context.Pizzas.Find(id);
        }

        [HttpGet]
        public List<Pizza> GetAll()
        {
            return _Context.Pizzas.OrderBy(a => a.Name).ToList();
        }

        [HttpPost]
        public void Post([FromBody] Pizza pizza)
        {
            _Context.Pizzas.Add(pizza);
            _Context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Pizza pizza = _Context.Pizzas.Find(id);
            _Context.Pizzas.Remove(pizza);
            _Context.SaveChanges();
        }
    }
}
