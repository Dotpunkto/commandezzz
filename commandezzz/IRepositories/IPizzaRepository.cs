using System.Collections.Generic;
using commandezzz.Model;

namespace commandezzz.IRepositories
{
    public interface IPizzaRepository
    {
        Pizza GetPizza(int id);
        List<Pizza> GetAllPizza();
        void AddPizza(Pizza pizza);
        void DeletePizza(int id);
    }
}