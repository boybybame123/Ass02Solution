using BusinessObject;
using DataAccess.Access;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            IDataReader dataReader = null;
            var products = new List<Product>();
            string SQLSelect = "select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock from Product";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new Product
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetInt32(4),
                        UnitsInStock = dataReader.GetInt32(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }
        public Product GetProductById(int productId)
        {
            Product product = null;
            IDataReader dataReader = null;
            string SQLSelect = "select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock" +
                " from Product where Product = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new Product
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetInt32(4),
                        UnitsInStock = dataReader.GetInt32(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return product;
        }
        public void AddNew(Product product)
        {
            try
            {
                Product pro = GetProductById(product.ProductId);
                if (pro == null)
                {
                    string SQLInsert = "insert Order values(@ProductId,@CategoryId,@ProductName,@Weight,@UnitPrice,@UnitsInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 50, product.UnitPrice, DbType.Currency));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Product product)
        {
            try
            {
                Product pro = GetProductById(product.ProductId);
                if (pro != null)
                {
                    string SQLUpdate = "Update Product set ProductId = @ProductId,CategoryId = @CategoryId,ProductName = @ProductName " +
                        "Weight = @Weight,UnitPrice = @UnitPrice,UnitsInStock = @UnitsInStock where ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 50, product.UnitPrice, DbType.Currency));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Product does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int productId)
        {
            try
            {
                Product pro = GetProductById(productId);
                if (pro != null)
                {
                    string SQLDelete = "Delete Product where ProductId = @ProductId";
                    var parameters = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters);
                }
                else
                {
                    throw new Exception("Product does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
