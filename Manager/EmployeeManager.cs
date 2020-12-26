using DAL;
using Entites;
using System;

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
    }
}
