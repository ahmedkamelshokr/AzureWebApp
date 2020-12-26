using DAL;
using Entites;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Manager
{
    public class EmployeeManager
    {
        private readonly EmployeeRepository repository;

        public EmployeeManager(EmployeeRepository repository)
        {
            this.repository = repository;
        }

        public Employee Get(int empId)
        {
            return repository.Get(empId);
        }

        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }
    }
}
