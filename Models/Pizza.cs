namespace PizzaPlace.Models;

public class Pizza
{
	public Pizza(int id, string nombre, decimal precio, NivelDePicante nivelDePicante)
	{
		this.Id = id;
		this.Nombre = nombre;
		this.Precio = precio;
		this.NivelDePicante = nivelDePicante;
	}
	public int Id { get;}
	public string Nombre { get;}
	public decimal Precio { get;}
	public NivelDePicante NivelDePicante { get;}

}
