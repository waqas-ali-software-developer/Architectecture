using HRM.Interface;
using HRM.Model;

namespace HRM.BAL
{
    //Dependency inversion principle
    /*  High level modules should not depend on low level modules. Both  should depend on the abstraction.
     * 
     */
    public class EmployeeBAL  //High level module
    {
        IDatabase _db;
        public EmployeeBAL()
        {
            _db = DataAcessFactory.GetCurrentDBObject();//tight coupling // low level module
        }

        public string GetEmployeeName(int id)
        {
            if (id > 0)
            {
                Employee employee = _db.Get_Employee(id);
                if (employee != null)
                {
                    string name = employee.Name;
                    return name;
                }
            }
            return "Employee not exist";        
        }
    }
}
