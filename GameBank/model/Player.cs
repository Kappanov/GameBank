using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.model
{
    internal class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public string Password { get; set; }
        public Bank[] Bank { get; set; }
        public Work Work { get; set; }

        public int Money { get; set; }
    }
}
