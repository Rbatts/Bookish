using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Bookish.data_access;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Database();
            List<Users> ourUsers = database.GetUserInformation();
            foreach (var user in ourUsers)
            {
                Console.WriteLine("UserID "+user.UserID);
                Console.WriteLine("First Name "+user.FirstName);
                Console.WriteLine("Last Name "+user.LastName);
                Console.WriteLine("User Name "+user.UserName);
                Console.WriteLine("Password "+user.Password);
            }
            List<Books> ourBooks = database.GetBookInformation();
            foreach (var book in ourBooks)
            {
                Console.WriteLine("Book " + book.BookId);
                Console.WriteLine("Book Title " + book.BookTitle);
                Console.WriteLine("Author " + book.Author);
            }
            List<Copy> ourCopy = database.GetCopyInformation();
            foreach (var copy in ourCopy)
            {
                Console.WriteLine("Copy ID " + copy.CopyID);
                Console.WriteLine("Book ID " + copy.BookID);
                Console.WriteLine("Person Borrowing Book ID" + copy.PersonBorrowingID);
                Console.WriteLine("Due Date" + copy.DueDate);
            }
                Console.ReadLine();
        }
    }
}
