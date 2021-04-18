using System.Collections.Generic;
using System.Linq;
using commandezzz.DataAccess;
using commandezzz.IRepositories;
using commandezzz.Model;

namespace commandezzz.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly CommandeContext _Context;

        public PizzaRepository(CommandeContext context)
        {
            _Context = context;
        }

        public Pizza GetPizza(int id)
        {
            return _Context.Pizzas.Find(id);
        }

        public List<Pizza> GetAllPizza()
        {
            return _Context.Pizzas.OrderBy(a => a.Name).ToList();
        }

        public void AddPizza(Pizza pizza)
        {
            _Context.Pizzas.Add(pizza);
            _Context.SaveChanges();
        }

        public void DeletePizza(int id)
        {
            Pizza pizza = GetPizza(id);
            _Context.Pizzas.Remove(pizza);
            _Context.SaveChanges();
        }
    }
}