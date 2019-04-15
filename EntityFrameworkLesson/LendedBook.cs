using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson
{
    public class LendedBook : Entity
    {

        public Book Book { get; set; }
        
        public DateTime FavorDate { get; set; }
    }
}
