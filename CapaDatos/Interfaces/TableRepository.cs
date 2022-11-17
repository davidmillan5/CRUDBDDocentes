using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntity;

namespace CapaDatos.Interfaces
{
    public class TableRepository : IGenericRepository<Docente>
    {


        private readonly BdDocentesContext _dbcontext;

        public TableRepository(BdDocentesContext context)
        {
            _dbcontext = context;
        }

        public async Task<bool> Actualizar(Docente modelo)
        {
            _dbcontext.Docentes.Update(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(string id)
        {
            Docente modelo = _dbcontext.Docentes.First(c => c.IdDocente == id);
            _dbcontext.Docentes.Remove(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Docente modelo)
        {
            _dbcontext.Docentes.Add(modelo);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<Docente> Obtener(string id)
        {
            return await _dbcontext.Docentes.FindAsync(id);
        }

        public async Task<IQueryable<Docente>> ObtenerTodos()
        {
            IQueryable<Docente> queryDocenteSQL = _dbcontext.Docentes;
            return queryDocenteSQL;
        }

        Task<bool> IGenericRepository<Docente>.Obtener(string id)
        {
            throw new NotImplementedException();
        }
    }
}
