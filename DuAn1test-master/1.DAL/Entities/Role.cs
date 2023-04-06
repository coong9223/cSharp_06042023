using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
