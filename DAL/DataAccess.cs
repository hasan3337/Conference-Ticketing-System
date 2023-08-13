using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Admin, int, bool> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<Staff, int, bool> StaffData()
        {
            return new StaffRepo();
        }
    }
}
