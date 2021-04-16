﻿using System;
using System.Collections.Generic;
using commandezzz.Model;
using Microsoft.AspNetCore.Mvc;
using commandezzz.IServices;
namespace commandezzz.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PizzasController : Controller
    {
        public IPizzaService _pizzaService;

        public PizzasController(IPizzaService pizzaService) { _pizzaService = pizzaService; Console.WriteLine("coucou"); Console.WriteLine("coucou"); Console.WriteLine("coucou"); Console.WriteLine("coucou"); }

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
