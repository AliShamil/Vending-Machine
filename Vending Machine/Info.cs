using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Info
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? EnteredAmount { get; set; }
        public string? Leftover { get; set; }
        public DateTime OperationTime { get; set; }

    }
}
