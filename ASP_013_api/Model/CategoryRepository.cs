using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ASP_013_api.Model
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
    }
    public class CategoryRepository : ICategoryRepository
    {
        string connectionString = null;
        public CategoryRepository(string _conectionString)
        {
            connectionString = _conectionString;
        }
        public List<Category> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                    {
                return db.Query<Category>("SELECT * FROM Category").ToList();
            }
        }
    }
}
