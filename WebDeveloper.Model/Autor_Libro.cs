using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public class Autor_Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int au_id{ get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int title_id { get; set; }
        public string au_ord { get; set; }
        public string royaltyper { get; set; }
    }
}
