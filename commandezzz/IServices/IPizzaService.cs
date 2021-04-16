using System.Collections.Generic;
using commandezzz.Model;

namespace commandezzz.IServices
{
    public interface IPizzaService
    {
        Pizza GetPizza(int id);
        List<Pizza> GetAllPizza();
        void AddPizza(Pizza pizza);
        void DeletePizza(int id);
    }
}