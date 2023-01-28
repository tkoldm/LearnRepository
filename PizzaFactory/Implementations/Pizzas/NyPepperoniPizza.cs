using PizzaProblem.Abstractions;
using PizzaProblem.Implementations.Factory;

namespace PizzaProblem.Implementations.Pizzas;

public class NyPepperoniPizza : Pizza
{
    public NyPepperoniPizza()
    {
        Name = "Pepperoni pizza in NY style";
        PizzaIngredientFactory = new NyIngredientFactory();
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = PizzaIngredientFactory.CreateDough();
        Sauce = PizzaIngredientFactory.CreateSauce();
        Cheese = PizzaIngredientFactory.CreateCheese();
        Pepperoni = PizzaIngredientFactory.CreatePepperoni();
    }
}