namespace PizzaProblem.Abstractions.Ingredients;

public class Pepperoni : IIngredient
{
    private protected string Description;

    public string GetDescription() => Description;
}