using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetOrderById(int orderId) => OrderDAO.Instance.GetOrderById(orderId);
        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();
        public void InsertOrder(Order order) => OrderDAO.Instance.AddNew(order);
        public void DeleteOrder(int orderId) => OrderDAO.Instance.Remove(orderId);
        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}
