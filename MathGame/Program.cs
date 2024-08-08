using System.Globalization;
using MathGame;

// Inicio

DateTime date = DateTime.Now;
string fecha = date.ToString("D", new CultureInfo("es-ES"));

string name = Helpers.ObtenerNombre();
Menu menu = new Menu();

// Programa

menu.MostrarMenu(name, fecha);

// Métodos