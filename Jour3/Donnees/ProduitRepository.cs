using Jour3.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour3.Donnees
{
    public class ProduitRepository
    {
        private readonly List<Produit> _produits = [];

        public void Ajouter(Produit produit)
        {
            _produits.Add(produit);
        }

        public IReadOnlyList<Produit> ObtenirTous()
        {
            return _produits;
        }
    }
}
