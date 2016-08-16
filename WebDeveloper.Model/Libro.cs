using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int title_id { get; set; }

        [Required]
        [StringLength(30)]
        public string title { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }
        
        public int pub_id { get; set; }
        public double price { get; set; }
        public string advance { get; set; }
        public string royalty { get; set; }
        public string ytd_sales { get; set; }
        public string notes { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime pubdate { get; set; }

    }
}
