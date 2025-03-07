using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_Objects2
{
    internal class Access
    {
        string? password = "abc123";

        public bool Login(string password)
        {
            return this.password == password;
        }
    }
}