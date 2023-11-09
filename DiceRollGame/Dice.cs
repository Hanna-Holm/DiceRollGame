namespace DiceRollGame
{
    public class Dice
    {
        public int Sides { get; init; }

        public Dice(int sides) 
        { 
            Sides = sides;
        }

        public int Roll()
            => new Random().Next(1, Sides + 1);
    }
}