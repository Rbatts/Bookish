using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.data_access
{
    public class Copy
    {
        public int CopyID  { get; set; }
        public int BookID { get; set; }
        public int PersonBorrowingID  { get; set; }
        public DateTime DueDate  { get; set; }
    }
}
