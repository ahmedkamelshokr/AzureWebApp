using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entites;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeManager manager;

        public EmployeeController(EmployeeManager manager)
        {
            this.manager = manager;
        }

        //GET: Employee/Details/5
        [HttpGet]
        [Route("details/{id?}")]
        public Employee Details(int id)
        {
            return manager.Get(id);
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return manager.GetAll();
        }

    }
}