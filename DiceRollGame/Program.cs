namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice sixSidedDice = new Dice(6);
            GuessingGame guessingGame = new GuessingGame(sixSidedDice);
            guessingGame.Start();

            Console.ReadKey();
        }
    }
}