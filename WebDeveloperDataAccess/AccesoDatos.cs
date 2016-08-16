using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloperDataAccess
{
    public interface AccesoDatos<T>
    {
        List<T> Lista();
        int Agregar(T entity);
        int Eliminar(T entity);
        int Editar(T entity);
        int Contador();
    }
}
