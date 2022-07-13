using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProduct
    {
        public void DeleteProduct(Product p)
        {
            ProductObject.DeleteProduct(p);
        }

        public List<Product> GetAllProducts() => ProductObject.GetProduct();

        public List<Category> GetCategories() => ProductObject.GetCategories();
       

        

        public void SaveProduct(Product p)
        {
            ProductObject.SaveProduct(p);
        }

        public List<Product> Search(int ad) => ProductObject.Search(ad); 
       

        public List<Product> Searching(string ad) => ProductObject.Searching(ad);


        public List<Order> SearchOrder(int p) => ProductObject.SearchOrder(p);


        public List<OrderDetail> SearchOrderdetail(int p) => ProductObject.SearchOrderdetail(p);
        public List<Product> SearchProduct(int p) => ProductObject.SearchProduct(p);

        public List<Product> SearchUnitPrice(decimal ad) => ProductObject.SearchUnitPrice(ad);
       

        public void UpdateProduct(Product p)
        {
            ProductObject.UpdateProduct(p);
        }
    }
}
