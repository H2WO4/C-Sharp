using PMU.Enums;


namespace PMU;

public static class Program
{
    public static void Main(string[] args)
    {
        int nbHorses = AskNumericalInput("How many horses?", 5, 24);
        var raceType = (RaceType) AskNumericalInput("TODO", 3, 5);

        int winningPerms = Factorial(nbHorses) / Factorial(nbHorses - (int) raceType + 1);
        int permutations = Factorial((int) raceType);

        double probability = 1d / ((double) winningPerms / permutations);

        Console.WriteLine($"You have {probability:p2} to win at {raceType}");
    }

    /// <summary>
    /// Ask the user for a number and check that it is in between bounds
    /// </summary>
    /// <param name="msg">The message to use when asking input</param>
    /// <param name="lowBound">The low bound (inclusive)</param>
    /// <param name="highBound">The high bound (inclusive)</param>
    /// <returns>The first correct value</returns>
    private static int AskNumericalInput(in string msg, in int lowBound, in int highBound)
    {
        while (true)
        {
            Console.WriteLine(msg);

            int output;
            if (int.TryParse(Console.ReadLine()!, out output) is false)
            {
                Console.Error.WriteLine("Non-integer value!");
                continue;
            }

            if (output < lowBound
             || output > highBound)
            {
                Console.Error.WriteLine("Value out of bounds!");
                continue;
            }

            return output;
        }
    }

    /// <summary>
    /// Calculate the factorial of an integer
    /// </summary>
    /// <param name="input">The starting value</param>
    private static int Factorial(in int input)
    {
        checked
        {
            if (input is 0 or 1)
                return 1;

            return input * Factorial(input - 1);
        }
    }
}