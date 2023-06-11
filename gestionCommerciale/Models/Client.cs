using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommerciale.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Number { get; set; }

        public string Ville { get; set; }

        public Client(int id, string nom, string number, string ville)
        {
            Id = id;
            Nom = nom;
            Number = number;
            Ville = ville;
        }
    }
}
