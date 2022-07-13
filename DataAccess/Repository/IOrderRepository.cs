using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrder
    {
        void SaveOrder(Order p);
        void DeleteOrder(Order p);
        void UpdateOrder(Order p);
        List<Member> GetMembers();
        List<Order> GetOrder();
        
    }
}
