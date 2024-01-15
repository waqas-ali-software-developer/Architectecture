using HRM.Interface;
using HRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public class SQLDB : IDatabase
    {
        public Employee Get_Employee(int id) 
        {
            //Database
            List<Employee> employees = new List<Employee>
            { 
               new Employee { Id = 1, Name = "Noor Mustafa"} ,
               new Employee { Id = 2, Name = "Waqas Ali"} ,
               new Employee { Id = 3, Name = "John Smith"} ,
            };

                return employees[id - 1];
        }

        public void Get_Employee()
        {
        }

            public void GetEmployeeData()
        {
        }
    }
}
