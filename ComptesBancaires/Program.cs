var comptes = new List<Compte>() {new Compte(100), new CompteEpargne(), new ComptePayant(-100)};
foreach (Compte c in comptes)
{
	c.deposer(100);
	if (c is CompteEpargne)
	{
		((CompteEpargne)c).calculInterets();
	}
	Console.WriteLine(c.ToString());
}

class Compte
{
	private static int nextCode = 0;
	protected int Code { get; }
	protected double Solde { set; get; }

	public Compte(double solde)
	{
		this.Code = nextCode++;
		this.Solde = solde;
	}
	public Compte() : this(0) {}

	public virtual void deposer(double montant)
	{
		if (montant <= 0)
		{
			throw new ArgumentException();
		}
		this.Solde += montant;
	}

	public virtual void retirer(double montant)
	{
		if (montant <= 0)
		{
			throw new ArgumentException();
		}
		this.Solde -= montant;
	}

	public override string ToString()
	{
		return $"{this.Code}: {this.Solde}";
	}
}

class CompteEpargne : Compte
{
	private const double tauxEpargne = 6;

	public CompteEpargne(double solde) : base(solde) {}
	public CompteEpargne() : base() {}

	public void calculInterets()
	{
		this.Solde *= 1 + tauxEpargne / 100;
	}
}

class ComptePayant : Compte
{
	private const double taxe = 5;

	public ComptePayant(double solde) : base(solde) {}
	public ComptePayant() : base() {}

	public override void deposer(double montant)
	{
		base.deposer(montant);
		this.Solde -= taxe;
	}

	public override void retirer(double montant)
	{
		base.retirer(montant);
		this.Solde -= taxe;
	}
}