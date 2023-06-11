using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace gestionCommerciale.Models
{
    public class RoleRepository
    {
        private string connectionString;

        public RoleRepository()
        {
            this.connectionString = "server = localhost; database = gestioncommerciale; uid = root; pwd =\"\";";
        }

        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id,nom FROM role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role();
                            role.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            role.Nom = reader.GetString(reader.GetOrdinal("nom"));
                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }
    }
}

