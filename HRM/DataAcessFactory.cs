using HRM.DAL;
using HRM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    public class DataAcessFactory
    {
        public static IDatabase GetCurrentDBObject()
        {
            return new OracleDB();
        }
    }
}
