// Exercice 1
/* Console.Write("Enter a number: ");
string input = Console.ReadLine() ?? "";
int intInput;

if (!int.TryParse(input, out intInput))
{
	Console.WriteLine("Invalid number");
} */

// Exercice 2
/* Console.Write("Enter a number: ");
string input2 = Console.ReadLine() ?? "";
int intInput2;

while (!int.TryParse(input2, out intInput2))
{
	Console.WriteLine("Invalid number");
	Console.Write("Enter a number: ");
	input2 = Console.ReadLine();
} */

// Exercice 3
/* Console.Write("Enter a date: ");
string input3 = Console.ReadLine() ?? "";
DateTime dateInput3;

if (!DateTime.TryParse(input3, out dateInput3))
{
	Console.WriteLine("Invalid date");
} */

// Exercice 4
/* Console.Write("Enter a date: ");
string input4 = Console.ReadLine() ?? "";
Console.Write("Enter another date: ");
string input42 = Console.ReadLine() ?? "";
DateTime dateInput4;
DateTime dateInput42;

if (DateTime.TryParse(input4, out dateInput4) && DateTime.TryParse(input42, out dateInput42))
{
	if (DateTime.Compare(dateInput42, dateInput4) == -1)
	{
		Console.WriteLine("End date is smaller than start date");
	}
}
else
{
	Console.WriteLine("Invalid date");
} */

// Exercice 5
try
{
	var JeanLuc = new Eleve("Jean-Luc", 20, 12.5);
	Console.WriteLine(JeanLuc.ToString());	
}
catch (Exception ex) { Console.WriteLine(ex.Message); }
try
{
	var JeanLuc = new Eleve("Jean-Luc", 29, 12.5);
	Console.WriteLine(JeanLuc.ToString());	
}
catch (Exception ex) { Console.WriteLine(ex.Message); }
try
{
	var JeanLuc = new Eleve("Jean-Luc", 20, -12.5);
	Console.WriteLine(JeanLuc.ToString());	
}
catch (Exception ex) { Console.WriteLine(ex.Message); }

class InvalidAgeException : Exception
{
	public InvalidAgeException() : base("L'âge doît être entre 18 et 26 ans") {}
	public InvalidAgeException(int age) : base($"L'âge doît être entre 18 et 26 ans - Valeur fournie : {age}") {}
}

class InvalidNoteException : Exception
{
	public InvalidNoteException() : base("La note doît être entre 0 et 20") {}
	public InvalidNoteException(double note) : base($"La note doît être entre 0 et 20 - Valeur fournie : {note}") {}
}

class Eleve
{
	private string? nom;
	private int age;
	private double moyenne;

	public Eleve(string nom, int age, double note)
	{
		this.setNom(nom).setAge(age).setMoyenne(note);
	}

	public Eleve setNom(string nom)
	{
		this.nom = nom;
		return this;
	}
	public string getNom()
	{
		return this.nom ?? "";
	}

	public Eleve setAge(int age)
	{
		if (age >= 18 && age <= 26)
		{
			this.age = age;
			return this;
		}
		throw new InvalidAgeException(age);
	}
	public int getAge()
	{
		return this.age;
	}

	public Eleve setMoyenne(double note)
	{
		if (note >= 0 && note <= 20)
		{
			this.moyenne = note;
			return this;
		}
		throw new InvalidNoteException(note);
	}
	public double getMoyenne()
	{
		return this.moyenne;
	}

	public override string ToString()
	{
		return $"{this.nom} : {this.age} ans - Moyenne = {this.moyenne}";
	}
}