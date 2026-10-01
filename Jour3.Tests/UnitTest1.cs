using Jour3.Donnees;
using Jour3.Service;

namespace Jour3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AjouterProduitTest()
        {
            // Arrange
            var repository = new Jour3.Donnees.ProduitRepository();
            var service = new Jour3.Service.ProduitService(repository);
            var id = 1;
            var nom = "Clavier";
            var prix = 10.0m;
            // Act
            // appel d'une fonction ou d'une méthode à tester
            service.AjouterProduit(id, nom, prix);
            // Assert
            var produit = Assert.Single(service.ObtenirProduits());
            Assert.Equal(id, produit.Id);
            Assert.Equal(nom, produit.Nom);
            Assert.Equal(prix, produit.Prix);
        }

        [Theory]
        [InlineData(1, "Clavier", 10.0)]
        [InlineData(2, "Souris", 5.0)]
        [InlineData(3, "Écran", 100.0)]
        [InlineData(4, "Casque", 50.0)]
        public void AjouterUnProduitTest(int id, string nom, decimal prix)
        {
            // Arrange
            var repository = new Jour3.Donnees.ProduitRepository();
            var service = new Jour3.Service.ProduitService(repository);
            // Act
            // appel d'une fonction ou d'une méthode à tester
            service.AjouterProduit(id, nom, prix);
            // Assert
            var produit = Assert.Single(service.ObtenirProduits());
            Assert.Equal(id, produit.Id);
            Assert.Equal(nom, produit.Nom);
            Assert.Equal(prix, produit.Prix);
        }

    }
}
