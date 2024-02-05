using System.Text.Json;
namespace PizzaPlace.Extension;

public static class DebuggingExtensions
{
	private static JsonSerializerOptions opciones = new JsonSerializerOptions { WriteIndented = true };
	private static string ToJson(this object obj) => JsonSerializer.Serialize(obj, opciones);
}
