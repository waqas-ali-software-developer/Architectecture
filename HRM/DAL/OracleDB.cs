using HRM.Interface;
using HRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL
{
    public class OracleDB : IDatabase
    {
        public Employee Get_Employee(int id)
        {
            //Oracle Database
            List<Employee> employees = new List<Employee>
            {
               new Employee { Id = 1, Name = "Corina Proca"} ,
               new Employee { Id = 2, Name = "Alex Troy"} ,
               new Employee { Id = 3, Name = "Mike Dan"} ,
            };

            return employees[id - 1];
        }

        public void GetEmployeeData()
        { 
        }
    }
}
