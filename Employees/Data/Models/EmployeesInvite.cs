using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class EmployeesInvite : Base
    {
        public string State { get; set; }
        public string Description { get; set; }
        public string Fullname { get; set; }
        public string EmailAdress { get; set; }

        public Team Team { get; set; }
        public Profile Profile { get; set; }
        public Position Position { get; set; }
    }
}
