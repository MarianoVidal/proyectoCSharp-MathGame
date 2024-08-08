namespace MathGame;

internal class Menu
{
    GameEngine motor = new GameEngine();

    internal void MostrarMenu(string name, string fecha)
    {
        bool sigueJugando = true;

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Hola {name.ToUpper()}. Hoy es {fecha}. Este es un juego de matemáticas.\n");
        Helpers.EsperaEnter();

        do
        {
            Console.Clear();
            Console.WriteLine($@"¿Qué juego deseas jugar hoy? Escoja alguna de las opciones:
V - Ver juegos pasados
S - Suma
R - Resta
M - Multiplicación
D - División
C - Cerrar el programa");
            Console.WriteLine("---------------------------------------------");

            string? gameSelected = Console.ReadLine();
            Random rand = new Random();

            // Elegir el tipo de juego

            switch (gameSelected?.Trim().ToUpper())
            {
                case "V":
                    Helpers.ObtenerJuegos();
                    break;
                case "S":
                    Console.WriteLine(" - Se ha seleccionado el juego Suma");
                    motor.JuegoSuma(rand);
                    break;
                case "R":
                    Console.WriteLine(" - Se ha seleccionado el juego Resta");
                    motor.JuegoResta(rand);
                    break;
                case "M":
                    Console.WriteLine(" - Se ha seleccionado el juego Multiplicación");
                    motor.JuegoMultiplicacion(rand);
                    break;
                case "D":
                    Console.WriteLine(" - Se ha seleccionado el juego División");
                    motor.JuegoDivision();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Saliendo del programa");
                    sigueJugando = false;
                    Environment.Exit(1);
                    break;
            }
        } while (sigueJugando);
    }
}