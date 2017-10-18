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
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string SqlString = "SELECT TOP 100 [UserID],[FirstName],[LastName],[UserName],[Password] FROM [Users]"; 
            var ourUsers = (List<Users>)db.Query<Users>(SqlString);
            foreach (var User in ourUsers)
            {
                Console.WriteLine("UserID "+User.UserID);
                Console.WriteLine("First Name "+User.FirstName);
                Console.WriteLine("Last Name "+User.LastName);
                Console.WriteLine("User Name "+User.UserName);
                Console.WriteLine("Password "+User.Password);
            }
            string BookSqlString = "SELECT TOP 100 [BookID],[BookTitle],[Author] FROM [Books]";
            var ourBooks = (List<Books>)db.Query<Books>(BookSqlString);
            foreach (var Book in ourBooks)
            {
                Console.WriteLine("Book " + Book.BookId);
                Console.WriteLine("Book Title " + Book.BookTitle);
                Console.WriteLine("Author " + Book.Author);
            }
            string CopySqlString = "SELECT TOP 100 [CopyID],[BookID],[PersonBorrowingID], [DueDate] FROM [Copy]";
            var ourCopy = (List<Copy>)db.Query<Copy>(CopySqlString);
            foreach (var Copy in ourCopy)
            {
                Console.WriteLine("Copy ID " + Copy.CopyID);
                Console.WriteLine("Book ID " + Copy.BookID);
                Console.WriteLine("Person Borrowing Book ID" + Copy.PersonBorrowingID);
                Console.WriteLine("Due Date" + Copy.DueDate);
            }
                Console.ReadLine();
        }
    }
}
