var articles = new List<Article>() {
	new Article(1, "Chocolat", 10, 100),
	new Article(2, "Cannabis", 30, 20),
	new Article(3, "Eau", 1, 500),
};

Article? TrouverArticle(List<Article> articles, int reference)
{
	return articles.Find((ar) => ar.GetReference() == reference);
}

void AjouterArticle(List<Article> articles, Article ar)
{
	if (!articles.Any((a) => a.GetReference == ar.GetReference))
	{
		articles.Append(ar);
	}
	else { throw new ArgumentException(); }
}

void SupprimerArticle(List<Article> articles, int reference)
{
	articles = articles.Where((ar) => ar.GetReference() != reference).ToList();
}

void ModifierArticle(List<Article> articles, int reference, string nom, double prix, int stock)
{
	Article? article = TrouverArticle(articles, reference);
	if (article != null)
	{
		article.SetNom(nom).SetPrix(prix).SetStock(stock);
	}
}

Article? TrouverArticleNom(List<Article> articles, string nom)
{
	return articles.Find((ar) => ar.GetNom() == nom);
}

class Article
{
	protected int Reference { get; }
	protected string? Nom { get; set; }
	protected double Prix { get; set; }
	protected int Stock { get; set; }

	public Article(int reference, string nom, double prix, int stock)
	{
		this.Reference = reference;
		this.Nom = nom;
		this.Prix = prix;
		this.Stock = stock;
	}

	public int GetReference() { return this.Reference; }

	public Article SetNom(string nom) { this.Nom = nom; return this; }
	public string GetNom() { return this.Nom ?? ""; }

	public Article SetPrix(double prix) { this.Prix = prix; return this; }
	public double GetPrix() { return this.Prix; }

	public Article SetStock(int stock) { this.Stock = stock; return this; }
	public int GetStock() { return this.Stock; }


	public override string ToString()
	{
		return $"{this.Reference} : {this.Nom}, {this.Prix} - {this.Stock}";
	}
}