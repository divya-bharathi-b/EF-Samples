using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst_sample.Models
{
    public class buyer
    {
        [Key]
        public int buyer_Id { get; set; }
        public string buyer_Name { get; set; }
        public int price { get; set; }

    }
}
