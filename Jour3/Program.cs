using Jour3.Donnees;
using Jour3.Service;

var repository = new ProduitRepository();
var produitService = new ProduitService(repository);

produitService.AjouterProduit(1, "Clavier", 49.99m);

foreach (var produit in produitService.ObtenirProduits())
{
    Console.WriteLine($"{produit.Id} - {produit.Nom} : {produit.Prix:C}");
}