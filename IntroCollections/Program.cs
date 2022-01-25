var articles = new List<Article>() {
	new Article(1, "Chocolat", 10, 100),
	new Article(2, "Cannabis", 30, 20),
	new Article(3, "Eau", 1, 500),
};

Article? TrouverArticle(List<Article> articles, int reference) => articles.Find((ar) => ar.Reference == reference);

void AjouterArticle(ref List<Article> articles, Article ar)
{
	if (!articles.Any((a) => a.Reference == ar.Reference))
	{
		articles = articles.Append(ar).ToList();
	}
	else { throw new ArgumentException(); }
}

void SupprimerArticle(ref List<Article> articles, int reference)
{
	articles = articles.Where((ar) => ar.Reference != reference).ToList();
}

void ModifierArticle(List<Article> articles, int reference, string nom, double prix, int stock)
{
	Article? article = TrouverArticle(articles, reference);
	if (article != null)
	{
		article.Nom = nom;
		article.Prix = prix;
		article.Stock = stock;
	}
}

Article? TrouverArticleNom(List<Article> articles, string nom) => articles.Find((ar) => ar.Nom == nom);

List<Article> TrouverArticlePrix(List<Article> articles, double prixBas, double prixHaut) => articles.Where((ar) => ar.Prix >= prixBas && ar.Prix <= prixHaut).ToList();

void AfficherArticles(List<Article> articles) => articles.ForEach((ar) => Console.WriteLine(ar));

Console.WriteLine(" - 1) Trouver un article par référence");
Console.WriteLine(" - 2) Ajouter un article");
Console.WriteLine(" - 3) Supprimer un article par référence");
Console.WriteLine(" - 4) Modifier un article par référence");
Console.WriteLine(" - 5) Trouver un article par nom");
Console.WriteLine(" - 6) Trouver un article par tranche de prix");
Console.WriteLine(" - 7) Afficher les articles");
Console.WriteLine(" - 8) Quitter");
bool quit = false;
while (!quit) {
	int command;
	Console.WriteLine();
	Console.Write("Entrez une commande : ");
	if (int.TryParse(Console.ReadLine(), out command))
	{
		int reference;
		string nom;
		double prix;
		double prix2;
		int stock;

		switch (command)
		{
			case 1:
				Console.Write("Entrez la référence : ");
				if (int.TryParse(Console.ReadLine(), out reference)) {
					Console.WriteLine(TrouverArticle(articles, reference));
				}
				break;

			case 2:
				Console.Write("Entrez la référence : ");
				if (int.TryParse(Console.ReadLine(), out reference)) {
					Console.Write("Entrez le nom : ");
					nom = Console.ReadLine() ?? "";
					Console.Write("Entrez le prix : ");
					if (double.TryParse(Console.ReadLine(), out prix)) {
						Console.Write("Entrez le stock : ");
						if (int.TryParse(Console.ReadLine(), out stock)) {
							AjouterArticle(ref articles, new Article(reference, nom, prix, stock));
						}
					}
				}
				break;

			case 3:
				Console.Write("Entrez la référence : ");
				if (int.TryParse(Console.ReadLine(), out reference)) {
					SupprimerArticle(ref articles, reference);
				}
				break;

			case 4:
				Console.Write("Entrez la référence : ");
				if (int.TryParse(Console.ReadLine(), out reference)) {
					Console.Write("Entrez le nom : ");
					nom = Console.ReadLine() ?? "";
					Console.Write("Entrez le prix : ");
					if (double.TryParse(Console.ReadLine(), out prix)) {
						Console.Write("Entrez le stock : ");
						if (int.TryParse(Console.ReadLine(), out stock)) {
							ModifierArticle(articles, reference, nom, prix, stock);
						}
					}
				}
				break;

			case 5:
				Console.Write("Entrez le nom : ");
				Console.WriteLine(TrouverArticleNom(articles, Console.ReadLine() ?? ""));
				break;

			case 6:
				Console.Write("Entrez le prix minimum : ");
				if (double.TryParse(Console.ReadLine(), out prix)) {
					Console.Write("Entrez le prix maximum : ");
					if (double.TryParse(Console.ReadLine(), out prix2)) {
						AfficherArticles(TrouverArticlePrix(articles, prix, prix2));
					}
				}
				break;

			case 7:
				AfficherArticles(articles);
				break;
			
			case 8:
				quit = true;
				break;

			default:
				Console.WriteLine("Commande invalide");
				break;
		}
	}
}

class Article
{
	protected int _reference;
	protected string? _nom;
	protected double _prix;
	protected int _stock;

	public int Reference { get => this._reference; }
	public string Nom { get => this._nom ?? ""; set => this._nom = value; }
	public double Prix { get => this._prix; set => this._prix = value; }
	public int Stock { get => this._stock; set => this._stock = value; }

	public Article(int reference, string nom, double prix, int stock)
	{
		this._reference = reference;
		this.Nom = nom;
		this.Prix = prix;
		this.Stock = stock;
	}

	public override string ToString()
	{
		return $"{this.Reference} : {this.Nom}, {this.Prix} - {this.Stock}";
	}
}