using System.Collections.Generic;
using commandezzz.IRepositories;
using commandezzz.IServices;
using commandezzz.Model;

namespace commandezzz.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _PizzaRepo;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _PizzaRepo = pizzaRepository;
        }

        public Pizza GetPizza(int id)
        {
            return _PizzaRepo.GetPizza(id);
        }

        public List<Pizza> GetAllPizza()
        {
            return _PizzaRepo.GetAllPizza();
        }

        public void AddPizza(Pizza pizza)
        {
            _PizzaRepo.AddPizza(pizza);
        }

        public void DeletePizza(int id)
        {
            _PizzaRepo.DeletePizza(id);
        }
    }
}