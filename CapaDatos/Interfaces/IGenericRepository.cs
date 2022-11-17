using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    //Sera una clase que utilizarán todos los modelos o metodos
    //Definimos el CRUD para todas las tablas
    public interface IGenericRepository<TEntityModel> where TEntityModel : class
    {
        //agregar metodos
        Task<bool> Insertar(TEntityModel entity);
        Task<bool> Actualizar(TEntityModel entity);
        Task<bool> Eliminar(String id);
        Task<bool> Obtener(String id);
        //Devuelve una tabla
        Task<IQueryable<TEntityModel>> ObtenerTodos();
    }

}
