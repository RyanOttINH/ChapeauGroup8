﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class Bill_DAO : DAOBase
    {
        //Get the order information coreesponding to the tableID
        public Order DB_GetOrderById(int tableId)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("SELECT orderID, taleID, billID, employeeID, [completed], [comment] FROM Orders WHERE tableID = @tableId;", connection);
            command.Parameters.AddWithValue("@tableId", tableId);
            SqlDataReader reader = command.ExecuteReader();
            Order order = null;

            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            reader.Close();
            CloseConnection();

            return order;
        }
        //Get all menu items of a specific order corresponding to the table for calculating the bill (necessary? - can use the one in menuitem_DAO?)
        public List<MenuItem> DB_GetAllItems()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT MenuItems.menuItemID, MenuItems.categoryID, MenuItems.dishName, MenuItems.price, MenuItems.stock, alcoholic FROM [Orders] JOIN OrderItems ON OrderItems.orderID = [Orders].orderID JOIN MenuItems ON OrderItems.menuItemID = MenuItems.menuItemID;", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<MenuItem> items = new List<MenuItem>();
            while (reader.Read())
            {
                MenuItem item = ReadItem(reader);
                items.Add(item);
            }
            reader.Close();
            CloseConnection();
            return items;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            int orderId = (int)reader["orderID"];
            Table table = (Table)reader["tableID"];
            int billId = (int)reader["billID"];
            Employee employee = (Employee)reader["employeeID"];
            bool completed = (bool)reader["completed"];
            string comment = (string)reader["comment"];

            return new Order(orderId, table, billId, employee, completed, comment);
        }
        private MenuItem ReadItem(SqlDataReader reader)
        {
            int id = (int)reader["menuItemID"];
            int catId = (int)reader["categoryID"];
            string name = (string)reader["dishname"];
            int price = (int)reader["price"];
            int stock = (int)reader["stock"];
            bool alcoholic = (bool)reader["alcoholic"];

            return new MenuItem(id, catId, name, price, stock, alcoholic);
        }
        //writing bill information to Bills table in the database
        //public void AddToBill(Bill bill)
        //{
        //    string query = "INSERT INTO Bills VALUES (" + bill.BillID + ",'" + bill.PaymentMethod + "'," + bill.Tax6 + "," + bill.Tax21 + "," + drink.VAT + "," + bill.Tip + "," + bill.Total + "); ";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}
    }
}