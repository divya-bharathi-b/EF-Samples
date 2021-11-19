using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst_sample.Models
{
    [Table("Author_Details")]
    public class author
    {
        public int authorId { get; set; }
        [Required]
        public string authorName { get; set; }

        public int phoneno { get; set; }

        [Column("BookName")]
        [StringLength(15)]
        public string bookname { get; set; }

        [StringLength(50)]
        public string description { get; set; }
    }
}
