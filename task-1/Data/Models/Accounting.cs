using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_1.Data.Models
{


    public class Accounting
    {
       
            public int AccountingID { get; set; }
            public int BookID { get; set; }
            public int UserID { get; set; }
       
            public Book Book { get; set; }
            public User User { get; set; }
       
    }
}
