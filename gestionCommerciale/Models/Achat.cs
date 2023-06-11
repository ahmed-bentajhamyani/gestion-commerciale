using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommerciale.Models
{
    public class Achat
    {
        public int Id { get; set; }
        public int FournisseurId { get; set; }
        public int ArticleId { get; set; }
        public int Quantite { get; set; }

        public Achat(int id, int fournisseurId, int articleId, int quantite)
        {
            Id = id;
            FournisseurId = fournisseurId;
            ArticleId = articleId;
            Quantite = quantite;
        }
    }


}
