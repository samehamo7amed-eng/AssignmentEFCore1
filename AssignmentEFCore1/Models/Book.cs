using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFCore1.Models
{
   public class Book
    {
        public int Id { get; set; }
        public string Title {set; get; }
        public  string ISBN { set; get; }
        public decimal Price { set; get; }
        public int NumOfPages {  set; get; }
        public int PublishedYear {  set; get; }
         public bool IsInStock {  set; get; }

    }
}
