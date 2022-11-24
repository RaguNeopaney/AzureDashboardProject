using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Dashboard.Models
{
    public class Households
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Hshd_num { get; set; }

        [MaxLength(1)]
        public string Loyalty_flag { get; set; }

        public string Age_range { get; set; }
        public string Marital_status { get; set; }
        public string Income_range { get; set; }
        public string Homeower_desc { get; set; }
        public string Hshd_composition { get; set; }
        public string Hshd_size { get; set; }
        public string children { get; set; }
    }
}