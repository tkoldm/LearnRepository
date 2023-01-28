using System.Text;
using PizzaProblem.Abstractions.Ingredients;

namespace PizzaProblem.Abstractions;

public abstract class Pizza
{
    private protected string Name;
    private protected Dough Dough;
    private protected Sauce Sauce;
    private protected Cheese Cheese;
    private protected Veggies[] Veggies = Array.Empty<Veggies>();
    private protected Pepperoni? Pepperoni;
    private protected IPizzaIngredientFactory PizzaIngredientFactory;

    public abstract void Prepare();
    // {
    //     Console.WriteLine($"Preparing {Name}...");
    //     Console.WriteLine($"\tTossing dough {Dough}...");
    //     Console.WriteLine($"\tAdding sauce {Sauce}...");
    //     Console.Write("\tAdding toppings...");
    //     foreach (var topping in Toppings)
    //     {
    //         Console.Write($" {topping}");
    //     }
    //     Console.WriteLine();
    // }

    public void Bake()
    {
        Console.WriteLine($"\tBaking {Name}...");
    }

    public void Cut()
    {
        Console.WriteLine($"\tCutting {Name}...");
    }

    public void Box()
    {
        Console.WriteLine($"\tBoxing {Name}...");
    }

    public override string ToString()
    {
        var descriptionSb = new StringBuilder($"{Name}: ");
        descriptionSb.Append($"{Dough.GetDescription()}\n");
        descriptionSb.Append($"{Sauce.GetDescription()}\n");
        if (Cheese != null)
        {
            descriptionSb.Append($"{Cheese.GetDescription()}\n");
        }
        
        if (Veggies != null  && Veggies.Any())
        {
            foreach (var veggy in Veggies)
            {
                descriptionSb.Append($"{veggy.GetDescription()}, ");
            }
        }
        if (Pepperoni != null)
        {
            descriptionSb.Append($"\n{Pepperoni.GetDescription()}\n");
        }

        return descriptionSb.ToString();
    }
}