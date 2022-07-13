using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductObject
    {

        
        public static List<Product> GetProduct()
        {
            var list = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Products.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }

        public static List<Category> GetCategories()
        {
            var list = new List<Category>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Categories.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }
        public static List<Product> Searching(string ad)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Products.Where(c => c.ProductName.Contains(ad)).ToList();

                    //   mem =  db.OrderDetails.FirstOrDefault(c => c.OrderId == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<Product> SearchUnitPrice(decimal ad)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Products.Where(c => c.UnitPrice == ad).ToList();

                    //   mem =  db.OrderDetails.FirstOrDefault(c => c.OrderId == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<Product> Search(int ad)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Products.Where(c => c.ProductId == ad|| c.UnitsInStock == ad).ToList();

                    //   mem =  db.OrderDetails.FirstOrDefault(c => c.OrderId == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public static void SaveProduct(Product p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateProduct(Product p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Entry<Product>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void DeleteProduct(Product p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    var b = db.Products.FirstOrDefault(c => c.ProductId == p.ProductId);
                    db.Products.Remove(b);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static List<Order> SearchOrder(int p)
        {
            var list = new List<Order>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list =  db.Orders.Where(c => c.MemberId == p).ToList();
                  db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<OrderDetail> SearchOrderdetail(int p)
        {
            var list = new List<OrderDetail>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list =  db.OrderDetails.Where(c => c.OrderId == p).ToList();
                    
                //   mem =  db.OrderDetails.FirstOrDefault(c => c.OrderId == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public static List<Product> SearchProduct(int p)
        {
            var list = new List<Product>();
            try
            {
                using (var db = new FStoreDBContext())
                {

                    list = db.Products.Where(c => c.ProductId == p).ToList();
                  
                    // mem =  db.Products.FirstOrDefault(c => c.ProductId == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}