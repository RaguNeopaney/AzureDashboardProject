using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Dashboard.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        public int Basket_num { get; set; }
        public DateTime Purchase_date { get; set; }
        public float Spend { get; set; }
        public int Units { get; set; }
        public string Store_region { get; set; }
        public int Week_num { get; set; }
        public string Year { get; set; }

        public int Product_num { get; set; }

        [ForeignKey("Product_num")]
        public Product Product { get; set; }

        public int Hshd_num { get; set; }

        [ForeignKey("Hshd_num")]
        public Households Households { get; set; }
    }
}