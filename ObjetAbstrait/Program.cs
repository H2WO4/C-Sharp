var Jose = new Patron(142, "José", "José", "2000-11-01", 4);
Patron.SetChiffreAffaire(10000);
Console.WriteLine(Jose);

abstract class Employe
{
	protected int Matricule { get; set; }
	protected string? Nom { get; set; }
	protected string? Prenom { get; set; }
	protected DateTime DateNaissance { get; set; }
	
	public Employe(int matricule, string nom, string prenom, DateTime dateNaissance)
	{
		this.Matricule = matricule;
		this.Nom = nom;
		this.Prenom = prenom;
		this.DateNaissance = dateNaissance;
	}
	public Employe(int matricule, string nom, string prenom, string dateNaissance) : this(matricule, nom, prenom, DateTime.Parse(dateNaissance)) {}

	public override string ToString()
	{
		return $"{this.Matricule} : {this.Prenom} {this.Nom}, {this.DateNaissance.ToShortDateString()}";
	}

	public abstract double GetSalaire();
}

class Ouvrier : Employe
{
	private const double SMIG = 2500;
	protected DateTime DateEmbauche { get; set; }

	public Ouvrier(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche) : base(matricule, nom, prenom, dateNaissance)
	{
		this.DateEmbauche = dateEmbauche;
	}
	public Ouvrier(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche) : this(matricule, nom, prenom, DateTime.Parse(dateNaissance), DateTime.Parse(dateEmbauche)) {}

	public int Anciennete()	{ return (this.DateEmbauche - DateTime.Now).Days % 365; }

	public override string ToString()
	{
		return $"{base.ToString()}, {this.DateEmbauche.ToShortDateString()}";
	}

	public override double GetSalaire()	{ return Math.Max(Ouvrier.SMIG + this.Anciennete() * 100, Ouvrier.SMIG * 2); }
}

class Cadre : Employe
{
	protected int Indice { get; set; }

	public Cadre(int matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
	{
		this.Indice = indice;
	}
	public Cadre(int matricule, string nom, string prenom, string dateNaissance, int indice) : this(matricule, nom, prenom, DateTime.Parse(dateNaissance), indice) {}

	public override string ToString()
	{
		return $"{base.ToString()} - {this.Indice}";
	}

	public override double GetSalaire()
	{
		switch (this.Indice)
		{
			case 1: return 13000;
			case 2:	return 15000;
			case 3:	return 17000;
			case 4:	return 20000;
			
			default: throw new ArgumentException();
		}
	}
}

class Patron : Employe
{
	protected static double ChiffreAffaire { get; set; }

	protected double Pourcentage { set; get; }

	public Patron(int matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
	{
		this.Pourcentage = pourcentage;
	}
	public Patron(int matricule, string nom, string prenom, string dateNaissance, double pourcentage) : this(matricule, nom, prenom, DateTime.Parse(dateNaissance), pourcentage) {}

	public static void SetChiffreAffaire(double valeur) { Patron.ChiffreAffaire = valeur; }
	public static double GetChiffreAffaire(double valeur) { return Patron.ChiffreAffaire; }

	public override string ToString()
	{
		return $"{base.ToString()} - {this.Pourcentage}%";
	}

	public override double GetSalaire()
	{
		return Patron.ChiffreAffaire * (this.Pourcentage / 100);
	}
}