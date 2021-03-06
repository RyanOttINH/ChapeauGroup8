﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class Employee_DAO : DAOBase
    {
        //Getting all employees' information
        public List<Employee> DB_GetAllEmployees()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT employeeID, [type], [username], [password] FROM [Employees]", connection);
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = ReadEmployee(reader);
                employees.Add(employee);
            }
            reader.Close();
            CloseConnection();
            return employees;
        }
        //Getiing an employee information corresponding to a specific id
        public Employee DB_GetEmployeeByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT [employeeID], [type], [username], [password] FROM [Employees] WHERE employeeID = @id", connection);
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Employee employee = null;
            if (reader.Read())
            {
                employee = ReadEmployee(reader);
            }
            reader.Close();
            CloseConnection();
            return employee;
        }

        public Employee DB_GetByUsername(string username)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT [employeeID], [type], [username], [password] FROM [Employees] WHERE [username] = @username", connection);
            queryGetByID.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            Employee employee;
            if (reader.Read())
            {
                employee = ReadEmployee(reader);
            }
            else
            {
                employee = null;
            }
            reader.Close();
            CloseConnection();
            return employee;
        }

        private Employee ReadEmployee(SqlDataReader reader)
        {
            int employeeID = (int)reader["employeeID"];
            int type = (int)reader["type"];
            string username = (string)reader["username"];
            string password = (string)reader["password"];

            return new Employee(employeeID, (Models.Type)type, username, password);
        }
    }
}

