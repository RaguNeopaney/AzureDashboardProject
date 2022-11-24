using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Dashboard.Models
{
    public class TransactionViewModel
    {
        public int Basket_num { get; set; }
        public string Purchase_date { get; set; }
        public float Spend { get; set; }
        public int Units { get; set; }
        public string Store_region { get; set; }
        public int Week_num { get; set; }
        public string Year { get; set; }
        public int Product_num { get; set; }
        public int Hshd_num { get; set; }
    }
}