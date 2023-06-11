using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCommerciale.Models
{
    public class AchatRepository
    {
        private string connectionString;
        public AchatRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }
        public void AjouterAchat(int fournisseurId, int articleId, int quantite)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO achat (fourn_id, art_id, qte) VALUES (@FournisseurId, @ArticleId, @Quantite)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FournisseurId", fournisseurId);
                command.Parameters.AddWithValue("@ArticleId", articleId);
                command.Parameters.AddWithValue("@Quantite", quantite);
                command.ExecuteNonQuery();
            }
        }

        public List<Achat> GetAllAchats()
        {
            List<Achat> achats = new List<Achat>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM achat";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(reader.GetOrdinal("id"));
                            int FournisseurId = reader.GetInt32(reader.GetOrdinal("fourn_id"));
                            int ArticleId = reader.GetInt32(reader.GetOrdinal("art_id"));
                            int Quantite = reader.GetInt32(reader.GetOrdinal("qte"));
                            achats.Add(new Achat(Id, FournisseurId, ArticleId, Quantite));
                        }
                    }
                }
            }
            return achats;
        }
    }
}
