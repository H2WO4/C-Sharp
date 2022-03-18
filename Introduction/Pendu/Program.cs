String word = "goblin";
int nbTry = 10;

String foundLetters = "_";
char letter;

while (nbTry > 0 && foundLetters.Contains("_"))
{
	Console.Write("Enter a letter: ");
	if (char.TryParse(Console.ReadLine(), out letter)) {
		if (char.IsLetter(letter)) {
			letter = char.ToLower(letter);
			if (word.Contains(letter))
			{
				for (int i = 0; i < word.Length; i++)
					if (word[i] == letter)
						foundLetters = foundLetters.Remove(i, 1).Insert(i, letter.ToString());
				
				Console.WriteLine("Current found letters: " + foundLetters);
			}
			else
			{
				nbTry--;
				Console.WriteLine("Incorrect! You have " + nbTry + " lives left.");
			}
			Console.WriteLine();
		}
		else
			Console.WriteLine("Please enter a letter.");
	}
	else
		Console.WriteLine("Invalid input!");
}

if (nbTry > 0)
	Console.WriteLine("You win!");
else
	Console.WriteLine("You lose!");