using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookish.data_access
{
    public class Database
    { 
        public IDbConnection Db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<Users> GetUserInformation()
        {
            string SqlString = "SELECT TOP 100 [UserID],[FirstName],[LastName],[UserName],[Password] FROM [Users]";
            var ourUsers = (List<Users>)Db.Query<Users>(SqlString);
            return ourUsers;
        }

        public List<Books> GetBookInformation()
        {
            string booksqlstring = "SELECT TOP 100 [BookID],[BookTitle],[Author] FROM [Books]";
            var ourBooks = (List<Books>)Db.Query<Books>(booksqlstring);
            return ourBooks;
        }

        public List<Copy> GetCopyInformation()
        {
            string copysqlstring = "SELECT TOP 100 [CopyID],[BookID],[PersonBorrowingID], [DueDate] FROM [Copy]";
            var ourCopy = (List<Copy>)Db.Query<Copy>(copysqlstring);
            return ourCopy;
        }

    }
}
