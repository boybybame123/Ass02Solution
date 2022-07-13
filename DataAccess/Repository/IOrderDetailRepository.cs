using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetail
    {

        void SaveOrderDetail(OrderDetail p, Order a);
        void DeleteOrderDetail(OrderDetail p, Order a);
        void UpdateOrderDetail(OrderDetail p, Order a);
        List<Product> GetProduct();
        List<Order> GetOrder();
        List<OrderDetail> GetOrderDetail();
        List<OrderList> SearchOrder();
        List<OrderList> SearchOrderdetails(int p);
        List<OrderList> SearchOrderByShippedDatebyMember(int a);
        List<OrderList> SearchOrderByShippedDate();
    }
}
