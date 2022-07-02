using BusinessObject;
using DataAccess.Access;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            IDataReader dataReader = null;
            var orders = new List<Order>();
            string SQLSelect = "select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight from Order";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetInt32(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orders;
        }
        public Order GetOrderById(int orderId)
        {
            Order order = null;
            IDataReader dataReader = null;
            string SQLSelect = "select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight" +
                " from Order where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new Order
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetInt32(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return order;
        }
        public void AddNew(Order order)
        {
            try
            {
                Order ord = GetOrderById(order.OrderId);
                if (ord == null)
                {
                    string SQLInsert = "insert Order values(@OrderId,@MemberId,@OrderDate,@RequiredDate,@ShippedDate,@Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 50, order.Freight, DbType.Currency));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Order order)
        {
            try
            {
                Order ord = GetOrderById(order.OrderId);
                if (ord != null)
                {
                    string SQLUpdate = "Update Order set OrderId = @OrderId,MemberId = @MemberId,OrderDate = @OrderDate " +
                        "RequiredDate = @RequiredDate,ShippedDate = @ShippedDate,Freight = @Freight where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 50, order.Freight, DbType.Currency));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Order does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int orderId)
        {
            try
            {
                Order ord = GetOrderById(orderId);
                if (ord != null)
                {
                    string SQLDelete = "Delete Order where OrderId = @OrderId";
                    var parameters = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters);
                }
                else
                {
                    throw new Exception("Order does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
