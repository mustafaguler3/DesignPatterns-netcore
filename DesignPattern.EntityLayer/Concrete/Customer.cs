using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
