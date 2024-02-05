using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models;

public class Cliente
{
	public int Id { get; set; }
	[Required(ErrorMessage = "Por Favor Introduce Tu Nombre.")]
	public string Nombre { get; set; } = default!;
	[Required(ErrorMessage ="Por Favor Escribe Tu Dirección")]
	public string Direccion { get; set; } = default!;
	[Required(ErrorMessage ="Por Favor Introducir Tu Ciudad.")]
	public string Ciudad { get; set; } = default!;
}
