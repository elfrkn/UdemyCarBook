using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
    }
}
