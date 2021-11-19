using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst_sample.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required()]
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Order> Orders { get; set; } //navigation prop
    }



    [Table("Order")]
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        public DateTime OrderDate { get; set; }

        [Column("OrderAmt")]
        public int Amount { get; set; }

        public Customer cust { get; set; } //navigation prop
    }
}
