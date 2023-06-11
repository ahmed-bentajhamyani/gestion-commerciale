using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommerciale.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string PU { get; set; }
        public Article(int id, string nom, string pu)
        {
            Id = id;
            Nom = nom;
            PU = pu;
        }
    }
}
