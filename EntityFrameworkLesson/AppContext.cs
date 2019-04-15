using System.Data.Entity;

namespace EntityFrameworkLesson
{
    public class AppContext : DbContext
    {

        public AppContext() : base("appContext")
        {}

        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<LendedBook> LendedBooks { get; set; }

        public virtual DbSet<Visitor> Visitors { get; set; }
    }
}
