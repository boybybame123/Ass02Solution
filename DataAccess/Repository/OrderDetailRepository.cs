using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetail
    {
        public void DeleteOrderDetail(OrderDetail p, Order a)
        {
            OrderDetailObject.DeleteOrderDetail(p, a);
        }

        public List<Order> GetOrder() => OrderDetailObject.GetOrder();


        public List<OrderDetail> GetOrderDetail() => OrderDetailObject.GetOrderDetail();

        public List<Product> GetProduct() => OrderDetailObject.GetProduct();


        public void SaveOrderDetail(OrderDetail p, Order a)
        {
            OrderDetailObject.SaveOrderDetail(p, a);
        }

        public List<OrderList> SearchOrder() => OrderDetailObject.SearchOrder();
        public List<OrderList> SearchOrderByShippedDate() => OrderDetailObject.SearchOrderByShippedDate();

        public List<OrderList> SearchOrderByShippedDatebyMember(int a)=> OrderDetailObject.SearchOrderByShippedDatebyMember(a);
      

        public List<OrderList> SearchOrderdetails(int p)=> OrderDetailObject.SearchOrderdetails(p);

      

        public void UpdateOrderDetail(OrderDetail p, Order a)
        {
            OrderDetailObject.UpdateOrderDetail(p,a);
        }
    }
}
