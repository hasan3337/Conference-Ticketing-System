using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Models;

namespace DAL.EF
{
    internal class CTSContext :DbContext 
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
