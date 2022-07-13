using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderObject
    {
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

        public static List<Member> GetMember()
        {
            var list = new List<Member>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Members.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }

        public static void SaveOrder(Order p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Orders.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void UpdateOrder(Order p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Entry<Order>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void DeleteOrder(Order p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    var b = db.Orders.SingleOrDefault(c => c.OrderId == c.OrderId);
                    db.Orders.Remove(b);
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
