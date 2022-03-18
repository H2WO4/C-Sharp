var lesGens = new List<Personne>() {
	new Employe("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 100),
	new Employe("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 100),
	new Employe("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 100),
	new Employe("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 100),
	new Employe("Pierre", "Blond", DateTime.Parse("2000-01-01"), 100),
	new Chef("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 1000, "RH"),
	new Chef("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 1000, "RH"),
	new Directeur("Pierre", "Pierre", DateTime.Parse("2000-01-01"), 10000, "PDG", "IUT Amiens"),
};

foreach (Personne p in lesGens)
{
	p.AfficherPersonne();
	Console.WriteLine();
}

class Personne
{
	protected string Nom { get; set; }
	protected string Prenom { get; set; }
	protected DateTime DateNaissance { get; set; }

	public Personne(string nom, string prenom, DateTime dateNaissance)
	{
		this.Nom = nom;
		this.Prenom = prenom;
		this.DateNaissance = dateNaissance;
	}

	public virtual void AfficherPersonne()
	{
		Console.WriteLine($"{this.Prenom} {this.Nom}");
		Console.WriteLine($"- Date de Naissance : {this.DateNaissance.ToShortDateString()}");
	}
}

class Employe : Personne
{
	protected double Salaire { get; set; }

	public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
	{
		this.Salaire = salaire;
	}

	public override void AfficherPersonne()
	{
		base.AfficherPersonne();
		Console.WriteLine($"- Salaire : {this.Salaire}");
	}
}

class Chef : Employe
{
	protected string Service { get; set; }

	public Chef(string nom, string prenom, DateTime dateNaissance, double salaire, string service) : base(nom, prenom, dateNaissance, salaire)
	{
		this.Service = service;
	}

	public override void AfficherPersonne()
	{
		base.AfficherPersonne();
		Console.WriteLine($"- Service : {this.Service}");
	}
}

class Directeur : Chef
{
	protected string Societe { get; set; }

	public Directeur(string nom, string prenom, DateTime dateNaissance, double salaire, string service, string societe) : base(nom, prenom, dateNaissance, salaire, service)
	{
		this.Societe = societe;
	}

	public override void AfficherPersonne()
	{
		base.AfficherPersonne();
		Console.WriteLine($"- Societe : {this.Societe}");
	}
}