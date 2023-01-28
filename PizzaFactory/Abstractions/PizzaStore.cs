using PizzaProblem.Implementations.Factory;

namespace PizzaProblem.Abstractions;

public abstract class PizzaStore
{
    private protected SimplePizzaFactory SimplePizzaFactory;
    
    public Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }

    private protected abstract Pizza CreatePizza(string type);
}