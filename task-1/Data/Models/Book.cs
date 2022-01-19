using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task_1.Data.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public string Discription { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }

        public ICollection<Accounting> Accountings { get; set; }
    }
}
