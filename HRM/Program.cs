using HRM.BAL;
using HRM.DAL;
using HRM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id");

            int employeeId = Convert.ToInt32(Console.ReadLine());
            EmployeeBAL empBAL = new EmployeeBAL();
            empBAL.GetEmployeeName(employeeId);

            IDatabase db = new SQLDB();

            db.GetEmployeeData();


            Console.ReadKey();
        }
    }
}
