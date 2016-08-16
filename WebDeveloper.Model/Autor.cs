using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int au_id { get; set; }

        [Required]
        [StringLength(50)]
        public string au_lname { get; set; }

        [Required]
        [StringLength(50)]
        public string au_fname { get; set; }

        [StringLength(20)]
        public string au_phone { get; set; }

        [StringLength(20)]
        public string au_city { get; set; }

        [StringLength(20)]
        public string au_state { get; set; }

        [StringLength(10)]
        public string au_zip { get; set; }

        [StringLength(1)]
        public string au_sex { get; set; }
        public double au_salary { get; set; }

        [StringLength(20)]
        public string au_subject { get; set; }

    }
}
