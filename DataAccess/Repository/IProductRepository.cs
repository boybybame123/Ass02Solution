using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProduct
    {
        void SaveProduct(Product p);
        void DeleteProduct(Product p);
        void UpdateProduct(Product p);

        List<Product> GetAllProducts();
        List<Category> GetCategories();
        List<Order>  SearchOrder(int p);
        List<OrderDetail>  SearchOrderdetail(int p);
        List<Product>  SearchProduct(int p);
        List<Product> Searching(string ad);
        List<Product> Search(int ad);
        List<Product> SearchUnitPrice(decimal ad);

    }
}
