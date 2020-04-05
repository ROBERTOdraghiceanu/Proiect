using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation.Logic
{
    public class User
    {
        public Guid UID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public int DateOfBrith { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public char Admin { get; set; }
    }
}
