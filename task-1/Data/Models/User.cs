using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_1.Data.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime RegistrationDate { get; set; }

        public ICollection<Accounting> Accountings { get; set; }
    }
}
