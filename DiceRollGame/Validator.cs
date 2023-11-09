namespace DiceRollGame
{
    public class Validator
    {
        public bool isGuessValid(string text)
        {
            bool isNumber = int.TryParse(text, out int result);

            if (isNumber)
                return true;

            return false;
        }

        public bool isGuessCorrect(string guess, int rolledNumber)
        {
            int.TryParse(guess, out int number);

            if (number == rolledNumber)
                return true;

            return false;
        }
    }
}