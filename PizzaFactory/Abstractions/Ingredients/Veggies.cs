namespace PizzaProblem.Abstractions.Ingredients;

public class Veggies : IIngredient
{
    private protected string Description;

    public string GetDescription() => Description;
}