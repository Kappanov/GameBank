using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.model
{
    internal class Bank
    {
        public  string Number { get; set; }
        public string Username { get; set; }

        public long Balance { get; set; }

        public int Pincode { get; set; }


    }
}
