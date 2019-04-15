using System.Collections.Generic;

namespace EntityFrameworkLesson
{
    public class Book : Entity
    {

        public string Name { get; set; }

        public int Price{get;set;}

        public List<Author> Authors { get; set; }
        
    }
}
