using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commandezzz.DataAccess;
using commandezzz.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace commandezzz.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost]
        public void Post([FromBody] Pizza pizza)
        {
            _Context.Pizzas.Add(pizza);
            _Context.SaveChanges();
        }
    }
}
