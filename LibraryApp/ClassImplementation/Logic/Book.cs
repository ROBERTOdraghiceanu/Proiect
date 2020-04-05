using ClassImplementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassImplementation.Logic
{
    public class Book
    {
        public Guid BID { get; set; }
        string Title { get; set; }
        int DateOfPublication { get; set; }
        float Price { get; set; }
        public ICategory Category { get; set; }
        public IAuthor Author { get; set; }
    }
}
