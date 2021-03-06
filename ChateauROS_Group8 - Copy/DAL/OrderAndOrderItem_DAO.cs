﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class OrderAndOrderItem_DAO : DAOBase
    {
        public List<OrderItem> DB_GetOrderItems()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT OrderItems.oderItemID, OrderItems.orderID, OrderItems.menuItemID, OrderItems.quantity, OrderItems.requests, OrderItems.orderState, OrderItems.lastStateChange, Orders.TableID FROM [OrderItems] LEFT JOIN [Orders] ON OrderItems.OrderID = Orders.OrderID ", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();
            while (reader.Read())
            {
                OrderItem orderItem = ReadOrderItem(reader);
                orderItems.Add(orderItem);
            }
            reader.Close();
            CloseConnection();
            return orderItems;
        }

        public List<OrderItem> DB_GetAllOrderItems(int orderID)
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT OrderItems.oderItemID, OrderItems.orderID, OrderItems.menuItemID, OrderItems.quantity, OrderItems.requests, OrderItems.orderState, OrderItems.lastStateChange, Orders.TableID FROM[OrderItems] LEFT JOIN[Orders] ON OrderItems.OrderID = Orders.OrderID WHERE OrderItems.OrderID = @id", connection);
            queryGetAll.Parameters.AddWithValue("@id", orderID);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();
            while (reader.Read())
            {
                OrderItem orderItem = ReadOrderItem(reader);
                orderItems.Add(orderItem);
            }
            reader.Close();
            CloseConnection();
            return orderItems;
        }

        public OrderItem DB_GetOrderItemByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT oderItemID, orderID, menuItemID, quantity, requests, orderState, lastStateChange FROM [OrderItems] WHERE orderItemID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            OrderItem orderItem = null;
            if (reader.Read())
            {
                orderItem = ReadOrderItem(reader);
            }
            reader.Close();
            CloseConnection();
            return orderItem;
        }

        public Order DB_GetOrderByTableID(int tableID)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT orderID, tableID, billID, employeeID, completed, comment FROM Orders WHERE tableID = @tableID AND completed <> 1", connection);
            queryGetByID.Parameters.AddWithValue("@tableID", tableID);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            if(reader.HasRows == false)
            {
                throw new Exception("There is no running order at the selected table");
            }
            reader.Close();
            CloseConnection();

            order.orderItems = DB_GetAllOrderItems(order.OrderID);

            return order;
        }

        public Order DB_GetLastOrder()
        {
            OpenConnection();
            SqlCommand queryMaxOrderID = new SqlCommand("SELECT TOP 1 * FROM [Orders] ORDER BY [orderID] DESC", connection);
            SqlDataReader reader = queryMaxOrderID.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            reader.Close();
            CloseConnection();
            return order;
        }

        public OrderItem DB_GetLastOrderItem()
        {
            OpenConnection();
            SqlCommand queryMaxOrderItemID = new SqlCommand("SELECT TOP 1 * FROM [OrderItems] ORDER BY [orderItemID] DESC", connection);
            SqlDataReader reader = queryMaxOrderItemID.ExecuteReader();
            OrderItem orderItem = null;
            if (reader.Read())
            {
                orderItem = ReadOrderItem(reader);
            }
            reader.Close();
            CloseConnection();
            return orderItem;
        }

        public void DB_AddOrderItem(OrderItem orderItem)
        {
            OpenConnection();
            SqlCommand queryAddOrder = new SqlCommand("INSERT INTO[OrderItems]([orderID], [menuItemID], [quantity], [requests], [orderState], [lastStateChange]) VALUES(@orderID, @menuItemID, @quantity, @requests, @orderState, @lastStateChange);", connection);
            queryAddOrder.Parameters.AddWithValue("@orderID", orderItem.OrderID);
            queryAddOrder.Parameters.AddWithValue("@menuItemID", orderItem.MenuItem.MenuItemID);
            queryAddOrder.Parameters.AddWithValue("@quantity", orderItem.Quantity);
            queryAddOrder.Parameters.AddWithValue("@requests", orderItem.Requests);
            queryAddOrder.Parameters.AddWithValue("@orderState", (int)orderItem.OrderState);
            queryAddOrder.Parameters.AddWithValue("@lastStateChange", orderItem.LastStateChange);
            queryAddOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_AddOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryAddOrder = new SqlCommand("INSERT INTO [Orders] ([tableID], [billID], [employeeID], [completed], [comment]) VALUES (@tableID, @billID, @employeeID, @completed, @comment);", connection);
            queryAddOrder.Parameters.AddWithValue("@tableID", order.Table.TableID);
            queryAddOrder.Parameters.AddWithValue("@billID", order.BillID);
            queryAddOrder.Parameters.AddWithValue("@employeeID", order.Employee.EmployeeID);
            queryAddOrder.Parameters.AddWithValue("@completed", order.Completed);
            queryAddOrder.Parameters.AddWithValue("@comment", order.Comment);
            queryAddOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_UpdateOrderStatusToPreparing(OrderItem currentOrder)
        {
            OpenConnection();
            SqlCommand queryEditOrderStatus = new SqlCommand("UPDATE [OrderItems] SET [orderState] = @orderState, [lastStateChange] = @lastStateChange WHERE [oderItemID] = @oderItemID", connection);
            queryEditOrderStatus.Parameters.AddWithValue("@orderState", currentOrder.OrderState);
            queryEditOrderStatus.Parameters.AddWithValue(@"lastStateChange", currentOrder.LastStateChange);
            queryEditOrderStatus.Parameters.AddWithValue("@oderItemID", currentOrder.OrderItemID);
            queryEditOrderStatus.ExecuteNonQuery();
            CloseConnection();
        }
        public void DB_UpdateOrderStatusToReady(OrderItem currentOrder)
        {
            OpenConnection();
            SqlCommand queryEditOrderStatus = new SqlCommand("UPDATE [OrderItems] SET [orderState] = @orderState, [lastStateChange] = @lastStateChange WHERE [oderItemID] = @oderItemID", connection);
            queryEditOrderStatus.Parameters.AddWithValue("@orderState", currentOrder.OrderState);
            queryEditOrderStatus.Parameters.AddWithValue(@"lastStateChange", currentOrder.LastStateChange);
            queryEditOrderStatus.Parameters.AddWithValue("@oderItemID", currentOrder.OrderItemID);
            queryEditOrderStatus.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_EditOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryEditOrder = new SqlCommand("UPDATE [Orders] SET [tableID] = @tableID, [billID] = @billID, [employeeID] = @employeeID, [completed] = @completed, [comment] = @comment WHERE [orderID] = @orderID", connection);
            queryEditOrder.Parameters.AddWithValue("@tableID", order.Table.TableID);
            queryEditOrder.Parameters.AddWithValue("@billID", order.BillID);
            queryEditOrder.Parameters.AddWithValue("@employeeID", order.Employee.EmployeeID);
            queryEditOrder.Parameters.AddWithValue("@completed", order.Completed);
            queryEditOrder.Parameters.AddWithValue("@comment", order.Comment);
            queryEditOrder.Parameters.AddWithValue("@orderID", order.OrderID);
            queryEditOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void DB_DeleteOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryDeleteOrder = new SqlCommand("DELETE FROM [Orders] WHERE [orderID] = @orderID", connection);
            queryDeleteOrder.Parameters.AddWithValue("@orderID", order.OrderID);
            queryDeleteOrder.ExecuteNonQuery();
            CloseConnection();
        }

        private OrderItem ReadOrderItem(SqlDataReader reader)
        {
            MenuItem_DAO menuItem_DAO = new MenuItem_DAO();
            Table_DAO table_DAO = new Table_DAO();

            int orderItemID = (int)reader["oderItemID"];
            int orderID = (int)reader["orderID"];
            MenuItem menuItem = menuItem_DAO.DB_GetMenuItemByID((int)reader["menuItemID"]);
            int quantity = (int)reader["quantity"];
            string requests = (string)reader["requests"];
            OrderState orderState = (OrderState)reader["orderState"];
            TimeSpan lastStateChange = (TimeSpan)reader["lastStateChange"];
            Table table = table_DAO.DB_GetTableByID((int)reader["tableID"]);

            return new OrderItem(orderItemID, orderID, menuItem, quantity, requests, orderState, table, lastStateChange); ;
        }

        private Order ReadOrder(SqlDataReader reader)
        {
            Table_DAO table_DAO = new Table_DAO();
            Employee_DAO employee_DAO = new Employee_DAO();
            Order order = new Order();

            int orderID = (int)reader["orderID"];
            Table table = table_DAO.DB_GetTableByID((int)reader["tableID"]);
            int billID = (int)reader["billID"];
            Employee employee = employee_DAO.DB_GetEmployeeByID((int)reader["employeeID"]);
            bool completed = (bool)reader["completed"];
            string comment = (string)reader["comment"];

            return new Order(orderID, table, billID, employee, completed, comment);

        }
    }
}

