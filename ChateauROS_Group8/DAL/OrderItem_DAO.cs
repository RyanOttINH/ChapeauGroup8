﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class OrderItem_DAO : DAOBase
    {
        public List<OrderItem> DB_GetAllOrderItems(int id)
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT oderItemID, orderID, menuItemID, quantity, requests, orderState, lastStateChange FROM [OrderItems] WHERE orderID = @id", connection);
            queryGetAll.Parameters.AddWithValue("@id", id);
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
            SqlCommand queryGetByID = new SqlCommand("SELECT orderID, tableID, billID, employeeID, completed, commment FROM [Orders] WHERE tableID = @tableID", connection);
            queryGetByID.Parameters.AddWithValue("@id", tableID);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            reader.Close();
            CloseConnection();
            return order;
        }

        private OrderItem ReadOrderItem(SqlDataReader reader)
        {
            MenuItem_DAO menuItem_DAO = new MenuItem_DAO();
            int orderItemID = (int)reader["oderItemID"];
            int orderID = (int)reader["orderID"];
            MenuItem menuItem = menuItem_DAO.DB_GetMenuItemByID((int)reader["menuItemID"]);
            int quatity = (int)reader["quantity"];
            string requests = (string)reader["requests"];
            string orderState = (string)reader["orderState"];
            TimeSpan lastStateChange = (TimeSpan)reader["lastStateChange"];

            return new OrderItem(orderItemID,orderID,menuItem,quatity,requests,orderState,lastStateChange);
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            Table_DAO table_DAO = new Table_DAO();
            Employee_DAO employee_DAO = new Employee_DAO();

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
