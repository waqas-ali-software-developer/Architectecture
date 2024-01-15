using HRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Interface
{
    public interface IDatabase // contract
    {
       Employee Get_Employee(int id);
       void GetEmployeeData();
    }
}
