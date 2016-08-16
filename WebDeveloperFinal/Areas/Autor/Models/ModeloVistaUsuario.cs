using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloperFinal.Areas.Autor.Models
{
    public class ModeloVistaUsuario
    {
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [EmailAddress]
        [Display(Name = "Nombre de usuario")]
        public string usuario { get; set; }
    }
}
