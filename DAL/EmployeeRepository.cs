﻿using Dapper;
using Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeRepository
    {

        private readonly SqlConnection Connection;
        public EmployeeRepository(string cnnStr)
        {
            Connection = new SqlConnection(cnnStr);
        }

        public Employee Get(int empId)
        {
            try
            {
                Connection.Open();
                return Connection.QuerySingleOrDefault<Employee>("SELECT * FROM dbo.Employee AS e WHERE e.Id = @empId", new { empId });
            }
            finally
            { Connection.Close(); }

        }

        public IEnumerable<Employee> GetAll()
        {
            try
            {
                Connection.Open();
                return Connection.Query<Employee>("SELECT * FROM dbo.Employee AS e " );
            }
            finally
            { Connection.Close(); }
        }
    }
}
