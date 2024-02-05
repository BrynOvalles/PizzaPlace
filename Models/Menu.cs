namespace PizzaPlace.Models;

public class Menu
{
	public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
	public void IncluirPizza(Pizza pizza) => Pizzas.Add(pizza);	
	public Pizza? ObtenerPizza(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
}
