using System;
using System.Collections;
using System.Collections.Generic;

namespace EntityFrameworkLesson
{
    public class Author : Entity
    {

        public string Name { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}