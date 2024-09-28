using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRC_system_of_registration_of_conscripts_.Database
{
    public class DatabaseTemplate
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsConscripted { get; set; }

       
    }
}
