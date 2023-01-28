using PizzaProblem.Abstractions;
using PizzaProblem.Implementations.Factory;

namespace PizzaProblem.Implementations.PizzaStores;

public class NyPizzaStore : PizzaStore
{
    public NyPizzaStore()
    {
        SimplePizzaFactory = new NySimpleFactory();
    }

    private protected override Pizza CreatePizza(string type)
    {
        var pizza = SimplePizzaFactory.CreatePizza(type);
        return pizza;
    }
}