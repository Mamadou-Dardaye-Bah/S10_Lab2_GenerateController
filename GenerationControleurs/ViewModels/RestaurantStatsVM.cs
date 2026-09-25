using LinqEtSeedEF.Models;

namespace GenerationControleurs.ViewModels
{
    public class RestaurantStatsVM
    {
            public RestaurantStatsVM(Restaurant restaurant)
            {
                // TODO: Écrire la logique nécessaire pour remplir les propriétés de cette vue
            }

            public string Nom { get; set; }
            public int NbCommandes { get; set; }
            public int NbPlatsVendus { get; set; }
            public decimal PrixTotalCommandes { get; set; }
            public decimal PrixMaxCommande { get; set; }
            public int MaxNiveauPiquant { get; set; }
        }

}
