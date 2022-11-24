using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_num { get; set; }

        public string Department { get; set; }
        public string Commodity { get; set; }
        public string Brand_type { get; set; }

        [MaxLength(1)]
        public string Natural_organic_flag { get; set; }
    }
}