using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloperDataAccess
{
    public class AccesoBaseDatos<T> : AccesoDatos<T> where T : class
    {
        public int Agregar(T entity)
        {
            using (var contextdb = new ContextoBD())
            {
                contextdb.Entry(entity).State = EntityState.Added;
                return contextdb.SaveChanges();
            }
        }

        public int Contador()
        {
            using (var contextdb = new ContextoBD())
            {
                return contextdb.Set<T>().Count();
            }
        }

        public int Editar(T entity)
        {
            using (var contextdb = new ContextoBD())
            {
                contextdb.Entry(entity).State = EntityState.Modified;
                return contextdb.SaveChanges();
            }
        }

        public int Eliminar(T entity)
        {
            using (var contextdb = new ContextoBD())
            {
                contextdb.Entry(entity).State = EntityState.Deleted;
                return contextdb.SaveChanges();
            }
        }

        public List<T> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
