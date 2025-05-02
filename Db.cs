namespace PizzaStore.DB;
// Set variables for Pizza, unique ID and Name
public record Pizza
{
    public int Id {get; set;}
    public string? Name {get;set;}

}
// Add data to a Pizza list using the defined varialbes
public class PizzaDB{
    private static List<Pizza> _pizzas = new List<Pizza>()
    {
        new Pizza {Id=1, Name="The Pepperoni Passion, Pizza loaded with pepperoni, peppers and more"},
        new Pizza {Id=2, Name="The Meat feast, Pizza loaded with chicken, beef, pepperoni and more"},
        new Pizza {Id=3, Name="The All World, Pizza loaded with various vegetables"}
    };

    // Get all the Pizzas
    public static List<Pizza> GetPizzas()
    {
        return _pizzas;
    }
}