using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst_sample.Models
{
    public class book
    {
        [Key]
        public int book_id { get; set; }
        public string book_name { get; set; }
        public int price { get; set; }
        public string author { get; set; }
        public int bookage { get; set; }
    }
}
