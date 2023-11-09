namespace DiceRollGame
{
    public class GuessingGame
    {
        private Dice Dice;
        private int _rolledNumber;
        private const int InitialTries = 3;
        private Validator _validator;

        public GuessingGame(Dice dice)
        {
            Dice = dice;
        }

        public void Start()
        {
            _rolledNumber = Dice.Roll();
            Console.WriteLine(
                $"Dice rolled. Guess what number it shows in {InitialTries} tries.");
            Play();
        }

        public void Play()
        {
            _validator = new Validator();
            int triesLeft = InitialTries;

            while (triesLeft > 0)
            {
                Console.WriteLine("Enter a number");
                string? userGuess = Console.ReadLine();

                if (_validator.IsGuessCorrect(userGuess, _rolledNumber))
                {
                    Console.WriteLine("You win!");
                    return;
                }
                else
                {
                    triesLeft--;
                    Console.WriteLine($"Wrong Number. {triesLeft} tries left.");
                }
            }

            Console.WriteLine("You lose!");
        }
    }
}
