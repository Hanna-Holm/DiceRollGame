﻿namespace DiceRollGame
{
    public class Validator
    {
        public bool IsGuessCorrect(string guess, int rolledNumber)
        {
            int.TryParse(guess, out int number);

            if (number == rolledNumber)
                return true;

            return false;
        }
    }
}
