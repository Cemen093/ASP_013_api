using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ASP_013_api.Model
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
    public class ProductRepository : IProductRepository
    {
        string connectionString = null;
        public ProductRepository(string _conectionString)
        {
            connectionString = _conectionString;
        }
        public List<Product> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Product>("SELECT * FROM Product").ToList();
            }
        }
    }
}
