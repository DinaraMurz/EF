using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var authors = new List<Author>{
                        new Author() { Name = "Макс Горький" },
                        new Author() { Name = "Пушкин А.C" },
                        new Author() { Name = "Microsoft" }
            };


            var books = new List<Book>
            {
                new Book(){
                    Name = "Сказки",
                    Price = 1500,
                    Authors = authors.FindAll(p => p.Name == "Пушкин А.C" || p.Name == "Макс Горький") },
                new Book(){
                    Name = "C#",
                    Price = 4000,
                    Authors = authors.FindAll(p => p.Name == "Microsoft") },
                new Book(){
                    Name = "C++",
                    Price = 2500,
                    Authors = authors.FindAll(p => p.Name == "Microsoft")}
            };

            var lendedBooks = new List<LendedBook>()
            {
                new LendedBook()
                {
                    Book = books.Find(p => p.Name == "C#"),
                    FavorDate =  new DateTime(2019, 04, 10) },
                new LendedBook()
                {
                    Book = books.Find(p => p.Name == "Сказки"),
                    FavorDate =  new DateTime(2019, 03, 21) }
            };

            var visitors = new List<Visitor>()
            {
                new Visitor() {FullName = "Сапарбек Франсуа",
                PhoneNumber = "870517965",
                LendedBooks = lendedBooks.FindAll(p => p.Book.Name == "Сказки")},
                new Visitor() {FullName = "Бекмырза",
                PhoneNumber = "870576649",
                LendedBooks = lendedBooks.FindAll(p => p.Book.Name == "C#")}
            };

            //using (var context = new AppContext())
            //{
            //    context.Authors.AddRange(authors);
            //    context.Books.Add(book);
            //    context.LendedBooks.Add(lendedBook);
            //    context.Visitors.Add(visitor);

            //    context.SaveChanges();

            //}


            //if(visitor.LendedBooks > DateTime.Now.AddDays(-7))
            //{

            //}

            //lendedBooks.FindAll(p => p.FavorDate == DateTime.Now.AddDays(7));

            //Console.WriteLine(DateTime.Now.AddDays(7).Date);
            //

            var listOfLenders = visitors.FindAll(p => p.LendedBooks.Any(p1 => p1.FavorDate.AddDays(7).Date <= DateTime.Now.Date));

            listOfLenders.ForEach(delegate (Visitor lended)
            {
                Console.WriteLine(lended.FullName);
            });



            //var listOfAuthorsBooks = new List<Author>();

            //foreach (Book aBook in books)
            //{
            //    listOfAuthorsBooks.Add(aBook.Authors.Find(p => p.Name == authors.ElementAt(2).Name));
            //}

            //foreach (Author author in listOfAuthorsBooks)   
            //{
            //    if(author.Name )
            //    Console.WriteLine(author.Name);
            //};

      

            Console.ReadLine();
        }
    }
}
