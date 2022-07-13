using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrder
    {
        public void DeleteOrder(Order p)
        {
            OrderObject.DeleteOrder(p);
        }

        public List<Member> GetMembers() => OrderObject.GetMember();


        public List<Order> GetOrder() => OrderObject.GetOrder();
       

        public void SaveOrder(Order p)
        {
            OrderObject.SaveOrder(p);
        }

        public void UpdateOrder(Order p)
        {
            OrderObject.UpdateOrder(p);
        }
    }
}
