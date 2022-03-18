using System.Reflection;

var Claude = new Employe(280, "Claude Claude", DateTime.Parse("1990-01-01"), DateTime.Parse("1980-01-01"), 0.1 + 0.2);
Claude.AfficherEmploye();

class Employe {
	private int _matricule;
	private string? _nom;
	private string? _prenom;
	private DateTime _dateNaissance;
	private DateTime _dateEmbauche;
	private double _salaire;

	public int Matricule { get => this._matricule; set => this._matricule = value; }
	public string NomComplet {
		get => $"{this._prenom} {this._nom}";
		set {
			var tmp = value.Split(' ');
			this._prenom = tmp[0];
			this._nom = tmp[1];
		}
	}
	public DateTime DateNaissance { get => this._dateNaissance; set => this._dateNaissance = value; }
	public DateTime DateEmbauche { get => this._dateEmbauche; set => this._dateEmbauche = value; }
	public double Salaire { get => this._salaire; set => this._salaire = value; }

	public Employe(int matricule, string nomComplet, DateTime dateNaissance, DateTime dateEmbauche, double salaire)
	{
		this.Matricule = matricule;
		this.NomComplet = nomComplet;
		this.DateNaissance = dateNaissance;
		this.DateEmbauche = dateEmbauche;
		this.Salaire = salaire;
	}

	public int Age()
	{
		return (this.DateNaissance - DateTime.Now).Days % 365;
	}

	public int Anciennete()
	{
		return (this.DateEmbauche - DateTime.Now).Days % 365;
	}

	public double AugmentationDuSalaire()
	{
		int anciennete = this.Anciennete();
		if (anciennete <= 5)
		{
			return this.Salaire * 1.02;
		}
		else if (anciennete <= 10)
		{
			return this.Salaire * 1.05;
		}
		else
		{
			return this.Salaire * 1.1;
		}
	}

	public void AfficherEmploye()
	{
		this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Select((prop) => new KeyValuePair<string, object?>(prop.Name, prop.GetValue(this))).ToList().ForEach((pair) => Console.WriteLine($"- {pair.Key} : {pair.Value}"));
	}
}