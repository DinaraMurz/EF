using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson
{
    public class Visitor : Entity
    {

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public List<LendedBook> LendedBooks { get; set; }
    }
}
