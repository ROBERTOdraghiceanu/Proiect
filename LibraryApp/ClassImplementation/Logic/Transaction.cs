using ClassImplementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation.Logic
{
    public class Transaction
    {
        public Guid TID { get; set; }
        public int units { get; set; }
        public IBook Book { get; set; }
        public IUser User { get; set; }
    }
}
