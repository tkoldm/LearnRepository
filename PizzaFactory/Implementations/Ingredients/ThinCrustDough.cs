using PizzaProblem.Abstractions.Ingredients;

namespace PizzaProblem.Implementations.Ingredients;

public class ThinCrustDough : Dough
{
    public ThinCrustDough()
    {
        Description = "Dough in NY style: thin with crust";
    }
}