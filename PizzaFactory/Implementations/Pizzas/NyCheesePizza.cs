using PizzaProblem.Abstractions;
using PizzaProblem.Implementations.Factory;

namespace PizzaProblem.Implementations.Pizzas;

public class NyCheesePizza : Pizza
{
    public NyCheesePizza()
    {
        PizzaIngredientFactory = new NyIngredientFactory();
        Name = "Cheese pizza in NY style";
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
    }
}