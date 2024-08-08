using MathGame.Models;

namespace MathGame;

internal class GameEngine
{
    private int limiteInferior = 1;

    internal void JuegoSuma(Random random)
    {
        int rondas = Helpers.ObtenerRondas();
        int limiteSuperior = Helpers.ElegirDificultad();

        int primerNumero;
        int segundoNumero;
        int rondasGanadas = 0;

        // El juego en sí

        for (int i = 0; i < rondas; i++)
        {
            // Asignar los números
            primerNumero = random.Next(limiteInferior, limiteSuperior);
            segundoNumero = random.Next(limiteInferior, limiteSuperior);

            Console.WriteLine($" * ¿Cuál es el resultado de sumar {primerNumero} + {segundoNumero} ?");
            Console.Write(" * ");

            int respuesta = Helpers.ObtenerNumero();

            if (respuesta == primerNumero + segundoNumero)
            {
                Console.WriteLine(" * ¡Has acertado!");
                rondasGanadas++;
            }
            else
            {
                Console.WriteLine(" * Lo sentimos, esa no era la respuesta correcta");
            }

            Helpers.EsperaEnter();
        }

        Console.WriteLine(" * ");
        Console.WriteLine($" * De {rondas} rondas has salido victorioso de {rondasGanadas}");
        Helpers.EsperaEnter();
        Helpers.AgregarAlHistorial(rondasGanadas, GameType.SUMA);
    }
    internal void JuegoResta(Random random)
    {
        int rondas = Helpers.ObtenerRondas();
        int limiteSuperior = Helpers.ElegirDificultad();

        int primerNumero;
        int segundoNumero;
        int rondasGanadas = 0;

        // El juego en sí

        for (int i = 0; i < rondas; i++)
        {
            // Asignar los números
            primerNumero = random.Next(limiteInferior, limiteSuperior);
            segundoNumero = random.Next(limiteInferior, limiteSuperior);

            Console.WriteLine($" * ¿Cuál es el resultado de restar {primerNumero} - {segundoNumero} ?");
            Console.Write(" * ");

            int respuesta = Helpers.ObtenerNumero();

            if (respuesta == primerNumero - segundoNumero)
            {
                Console.WriteLine(" * ¡Has acertado!");
                rondasGanadas++;
            }
            else
            {
                Console.WriteLine(" * Lo sentimos, esa no era la respuesta correcta");
            }

            Helpers.EsperaEnter();
        }

        Console.WriteLine(" * ");
        Console.WriteLine($" * De {rondas} rondas has salido victorioso de {rondasGanadas}");
        Helpers.EsperaEnter();
        Helpers.AgregarAlHistorial(rondasGanadas, GameType.RESTA);
    }
    internal void JuegoMultiplicacion(Random random)
    {
        int rondas = Helpers.ObtenerRondas();
        int limiteSuperior = Helpers.ElegirDificultad();

        int primerNumero;
        int segundoNumero;
        int rondasGanadas = 0;

        // El juego en sí

        for (int i = 0; i < rondas; i++)
        {
            // Asignar los números
            primerNumero = random.Next(limiteInferior, limiteSuperior);
            segundoNumero = random.Next(limiteInferior, limiteSuperior);

            Console.WriteLine($" * ¿Cuál es el resultado de multiplicar {primerNumero} * {segundoNumero} ?");
            Console.Write(" * ");

            int respuesta = Helpers.ObtenerNumero();

            if (respuesta == primerNumero * segundoNumero)
            {
                Console.WriteLine(" * ¡Has acertado!");
                rondasGanadas++;
            }
            else
            {
                Console.WriteLine(" * Lo sentimos, esa no era la respuesta correcta");
            }

            Helpers.EsperaEnter();
        }

        Console.WriteLine(" * ");
        Console.WriteLine($" * De {rondas} rondas has salido victorioso de {rondasGanadas} ");
        Helpers.EsperaEnter();
        Helpers.AgregarAlHistorial(rondasGanadas, GameType.MULTIPLICACIÓN);
    }
    internal void JuegoDivision()
    {
        int rondas = Helpers.ObtenerRondas();
        int limiteSuperior = Helpers.ElegirDificultad();

        int[] fracciones = Helpers.GenerarFraccionesEquivalentes(rondas, limiteSuperior);
        int curFrac = 0;
        int rondasGanadas = 0;

        // El juego en sí

        for (int i = 0; i < rondas; i++)
        {
            Console.WriteLine($" * ¿Cuál es el resultado de dividir {fracciones[curFrac]} / {fracciones[curFrac + 1]} ?");
            Console.Write(" * ");

            int respuesta = Helpers.ObtenerNumero();

            if (respuesta == (int)(fracciones[curFrac] / fracciones[curFrac + 1]))
            {
                Console.WriteLine(" * ¡Has acertado!");
                    rondasGanadas++;
                }
                else
                {
                    Console.WriteLine(" * Lo sentimos, esa no era la respuesta correcta");
                }
            Helpers.EsperaEnter();
            curFrac += 2;
        }

        Console.WriteLine(" * ");
        Console.WriteLine($" * De {rondas} rondas has salido victorioso de {rondasGanadas}");
        Helpers.EsperaEnter();
        Helpers.AgregarAlHistorial(rondasGanadas, GameType.DIVISIÓN);
    }
}