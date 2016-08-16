using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloperDataAccess
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base("WebDeveloperConnectionString")
        {
        }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Autor_Libro> Autor_Libro { get; set; }

       
    }
}
