using System.Linq.Expressions;
using TPPizza.Models;

namespace TPPizza.Data
{
    public class FakeDbPizza
    {
        private List<Pizza> _pizzas;
        private int _lastIndex { get => _pizzas.Count; }

        public FakeDbPizza()
        {
            _pizzas = InitialPizza.completePizzas;
        }

        public List<Pizza> GetAll()
        {
            return _pizzas;
        }

        public Pizza? GetById(int id)
        {
            return _pizzas.FirstOrDefault(p => p.Id == id);
        }

        public bool Add(Pizza pizza)
        {
            pizza.Id = _lastIndex;
            _pizzas.Add(pizza);
            return true;
        }

        public bool Update(Pizza update)
        {
            var pizza = GetById(update.Id);
            if (pizza is null) return false;

            _pizzas.Remove(pizza);
            _pizzas.Add(update);
            return true;
        }

        public bool Delete(int id)
        {
            var pizza = GetById(id);
            if (pizza is null) return false;
            _pizzas.Remove(pizza);
            return true;
        }
    }
}
