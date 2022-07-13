using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailObject
    {
        public static List<OrderList> SearchOrderdetails(int p)
        {
            var list = new List<OrderList>();
            try
            {
                using (var db = new FStoreDBContext())
                {


                    var lists = (from s in db.OrderDetails
                                 join c in db.Orders on s.OrderId equals c.OrderId

                                 select new
                                 {
                                     s.OrderId,
                                     s.ProductId,
                                     s.UnitPrice,
                                     s.Quantity,
                                     s.Discount,
                                     c.MemberId,
                                     c.OrderDate,
                                     c.RequiredDate,
                                     c.ShippedDate,
                                     c.Freight,

                                 }).Where(x=> x.MemberId== p);
                    foreach (var l in lists)
                    {
                        OrderList ord = new OrderList()
                        {
                            OrderId = l.OrderId,
                            MemberId = l.MemberId,
                            OrderDate = l.OrderDate,
                            RequiredDate = l.RequiredDate,
                            ShippedDate = l.ShippedDate,
                            Freight = l.Freight,
                            Discount = l.Discount,
                            Quantity = l.Quantity,
                            UnitPrice = l.UnitPrice,
                            ProductId = l.ProductId,

                        };


                        list.Add(ord);
                    }

                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<OrderList> SearchOrder()
        {
            var list = new List<OrderList>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                   

                    var lists = (from s in db.OrderDetails
                                 join c in db.Orders on s.OrderId equals c.OrderId

                                 select new
                                 {
                                     s.OrderId,
                                     s.ProductId,
                                     s.UnitPrice,
                                     s.Quantity,
                                     s.Discount,
                                     c.MemberId,
                                     c.OrderDate,
                                     c.RequiredDate,
                                     c.ShippedDate,
                                     c.Freight,

                                 });
                    foreach (var l in lists)
                    {
                        OrderList ord = new OrderList()
                        {
                            OrderId = l.OrderId,
                            MemberId = l.MemberId,
                            OrderDate = l.OrderDate,
                            RequiredDate = l.RequiredDate,
                            ShippedDate = l.ShippedDate,
                            Freight = l.Freight,
                            Discount=l.Discount,
                            Quantity=l.Quantity,
                            UnitPrice=l.UnitPrice,
                            ProductId=l.ProductId,
                            
                        };
                        

                        list.Add(ord);
                    }
                   
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<OrderList> SearchOrderByShippedDate()
        {
            var list = new List<OrderList>();
            try
            {
                using (var db = new FStoreDBContext())
                {


                    var lists = (from s in db.OrderDetails
                                 join c in db.Orders on s.OrderId equals c.OrderId

                                 select new
                                 {
                                     s.OrderId,
                                     s.ProductId,
                                     s.UnitPrice,
                                     s.Quantity,
                                     s.Discount,
                                     c.MemberId,
                                     c.OrderDate,
                                     c.RequiredDate,
                                     c.ShippedDate,
                                     c.Freight,

                                 }).OrderByDescending(c => c.ShippedDate);
                    foreach (var l in lists)
                    {
                        OrderList ord = new OrderList()
                        {
                            OrderId = l.OrderId,
                            MemberId = l.MemberId,
                            OrderDate = l.OrderDate,
                            RequiredDate = l.RequiredDate,
                            ShippedDate = l.ShippedDate,
                            Freight = l.Freight,
                            Discount = l.Discount,
                            Quantity = l.Quantity,
                            UnitPrice = l.UnitPrice,
                            ProductId = l.ProductId,

                        };


                        list.Add(ord);
                    }

                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<OrderList> SearchOrderByShippedDatebyMember(int a)
        {
            var list = new List<OrderList>();
            try
            {
                using (var db = new FStoreDBContext())
                {


                    var lists = (from s in db.OrderDetails
                                 join c in db.Orders on s.OrderId equals c.OrderId
                                 join e in db.Members on c.MemberId equals e.MemberId
                                 select new
                                 {
                                     s.OrderId,
                                     s.ProductId,
                                     s.UnitPrice,
                                     s.Quantity,
                                     s.Discount,
                                     c.MemberId,
                                     c.OrderDate,
                                     c.RequiredDate,
                                     c.ShippedDate,
                                     c.Freight,

                                 }).OrderByDescending(c => c.ShippedDate).Where(x=> x.MemberId == a);
                    foreach (var l in lists)
                    {
                        OrderList ord = new OrderList()
                        {
                            OrderId = l.OrderId,
                            MemberId = l.MemberId,
                            OrderDate = l.OrderDate,
                            RequiredDate = l.RequiredDate,
                            ShippedDate = l.ShippedDate,
                            Freight = l.Freight,
                            Discount = l.Discount,
                            Quantity = l.Quantity,
                            UnitPrice = l.UnitPrice,
                            ProductId = l.ProductId,

                        };


                        list.Add(ord);
                    }

                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<OrderDetail> GetOrderDetail()
        {
            var list = new List<OrderDetail>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.OrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }

        public static List<Order> GetOrder()
        {
            var list = new List<Order>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Orders.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }
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

        public static void SaveOrderDetail(OrderDetail p, Order a)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.OrderDetails.Add(p);
                    db.Orders.Add(a);
                    db.SaveChanges();
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateOrderDetail(OrderDetail p, Order a)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Entry<OrderDetail>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.Entry<Order>(a).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void DeleteOrderDetail(OrderDetail p, Order a)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    var b = db.OrderDetails.SingleOrDefault(c => c.OrderId == p.OrderId);
                    db.OrderDetails.Remove(b);
                    var o = db.Orders.FirstOrDefault(c => c.MemberId == a.MemberId);
                    db.Orders.Remove(o);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
