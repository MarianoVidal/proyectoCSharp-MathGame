using MathGame.Models;

namespace MathGame;

internal class Helpers
{
    internal static List<Game> juegos = new List<Game>();

    internal static void AgregarAlHistorial(int puntaje, GameType tipoJuego) => juegos.Add(new Game
    {
        Date = DateTime.Now,
        Score = puntaje,
        Type = tipoJuego
    });
    internal static bool EsFraccionEquivalente(int numerador, int denominador) => (numerador % denominador == 0);
    internal static void EsperaEnter()
    {
        Console.Write(" * (ENTER para continuar) ");
        Console.ReadLine();
    }
    internal static int ElegirDificultad()
    {
        bool elegida = false;
        int dificultad = 10;
        string? respuesta;

        while (!elegida)
        {
            Console.WriteLine(@" * ELIJA ALGUNA DE LAS SIGUIENTES DIFICULTADES: 
 - FACIL (el límite superior de numeros que te puedan tocar llega hasta 10)
 - MEDIA (el límite superior sube hasta 40)
 - DIFICIL (límite superior de 100)");
            Console.Write(" * ");
            respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "FACIL":
                    elegida = true;
                    break;
                case "MEDIA":
                    elegida = true;
                    dificultad = 40;
                    break;
                case "DIFICIL":
                    elegida = true;
                    dificultad = 100;
                    break;
                default:
                    Console.WriteLine(" * Esa dificultad no existe ");
                    break;
            }
        }

        return dificultad;
    }
    internal static int[] GenerarFraccionesEquivalentes(int rondas, int limite)
    {
        Random random = new Random();
        int[] devolver = new int[10];
        bool fraccionGenerada;

        int posibleNumerador;
        int posibleDenominador;

        for (int i = 0; i < rondas * 2; i = i + 2)
        {
            fraccionGenerada = false;

            while (!fraccionGenerada)
            {
                posibleNumerador = random.Next(1, limite);
                posibleDenominador = random.Next(1, limite);

                if (EsFraccionEquivalente(posibleNumerador, posibleDenominador))
                {
                    fraccionGenerada = true;
                    devolver[i] = posibleNumerador;
                    devolver[i + 1] = posibleDenominador;
                }
            }
        }

        return devolver;
    }
    internal static void ObtenerJuegos()
    {
        var juegosQuery = juegos.OrderByDescending(x => x.Score);

        Console.Clear();
        Console.WriteLine("Historial de Juegos");
        Console.WriteLine("---------------------------------------------");
        foreach (Game juego in juegosQuery)
            Console.WriteLine($" * {juego}");
        Console.WriteLine("---------------------------------------------\n");
        EsperaEnter();
    }
    internal static int ObtenerNumero()
    {
        int resultado;
        string? respuesta = Console.ReadLine();

        while (String.IsNullOrEmpty(respuesta) || !int.TryParse(respuesta, out resultado))
        {
            Console.Write(" * La respuesta debe ser un número\n * ");
            respuesta = Console.ReadLine();
        }

        return int.Parse(respuesta);
    }
    internal static int ObtenerRondas()
    {
        int resultado;
        Console.WriteLine(" * ¿Cuantas rondas desea jugar? ");
        Console.Write(" * ");
        string? respuesta = Console.ReadLine();

        while (String.IsNullOrEmpty(respuesta) || !int.TryParse(respuesta, out resultado) || resultado < 1)
        {
            Console.Write(" * La respuesta debe ser un número (natural)\n * ");
            respuesta = Console.ReadLine();
        }

        return int.Parse(respuesta);
    }
    internal static string ObtenerNombre()
    {
        Console.WriteLine("Introduzca su nombre: ");
        string? respuesta = Console.ReadLine();

        while (String.IsNullOrEmpty(respuesta))
        {
            Console.WriteLine(" * El nombre no puede estar vacío ");
            respuesta = Console.ReadLine();
        }

        return respuesta;
    }
}