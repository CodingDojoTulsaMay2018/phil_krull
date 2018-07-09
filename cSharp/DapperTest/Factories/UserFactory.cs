using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DapperTest.Models;
// added this import
using Microsoft.Extensions.Options;
 
namespace DapperTest.Factory
{
    public class UserFactory : IFactory<User>
    {
        private MySqlOptions _options;
        public UserFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(_options.ConnectionString);
            }
        }
        //USERFACTORY CLASS DEFINITION
 
        public void Add(User item)
        {
            using (IDbConnection dbConnection = Connection) {
                // change the column names to match your db
                string query =  "INSERT INTO users (name, email, password) VALUES (@Name, @Email, @Password)";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<User> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("SELECT * FROM users");
            }
        }
        public User FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<User>("SELECT * FROM users WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

    }
}
