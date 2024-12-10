using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.model
{
    internal class Work
    {
        public string Name { get; set; }
        
        public int RequiredLevel { get; set; }
        public int Salary { get; set; }
        public int WorkTime { get; set; }
        public Bank Bank { get; set; }
    }
}
