using LegacySystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacySystem
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Hours { get; set; }
        public int Rate { get; set; }
        public IEnumerable<PayItem> PayItems { get; set; }

    }
}
