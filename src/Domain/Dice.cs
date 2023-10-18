namespace Domain;

internal class Dice
{
    private readonly Random _randomizer = new();

    internal int Dots { get; private set; } = 6;

    internal Dice()
    {
       // Dots = 6;  kan ook
    }

    internal void Roll()
    {
        Dots = _randomizer.Next(1, 7);
    }
}
