using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation.Logic
{
    public class Author
    {
        public Guid AID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int DateOfBirth { get; set; }
    }
}
