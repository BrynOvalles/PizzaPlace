using System.Linq;
namespace PizzaPlace.Models;

public class Estado
{
	public Menu menu { get; } = new Menu();
	public CarritoDeCompras carrito { get; } = new CarritoDeCompras();
	public Interfaz interfaz { get; } = new Interfaz();
	public decimal PrecioTotal => carrito.Ordenes.Sum(id => menu.ObtenerPizza(id)!.Precio);
}
