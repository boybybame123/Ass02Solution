using BusinessObject;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();
        public void InsertProduct(Product product) => ProductDAO.Instance.AddNew(product);
        public void DeleteProduct(int productId) => ProductDAO.Instance.Remove(productId);
        public void UpdateProduct(Product product) => ProductDAO.Instance.Update(product);
    }
}