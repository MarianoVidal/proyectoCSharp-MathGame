namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }

    public override string ToString() => $"{Date} - {Type}: Puntaje = {Score} puntos";
}

internal enum GameType
{
    SUMA,
    RESTA,
    MULTIPLICACIÓN,
    DIVISIÓN
}