using MicroS.Infrastructure.DataAccess.Contracts.Entities;
using MicroS.Infrastructure.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroS.Infrastructure.DataAccess.Repositories
{
    //CRUD
    public class ComunaRepository : IComunaRepository
    {

        private readonly IMicroSDBContext _microSDBContext;
        public ComunaRepository(IMicroSDBContext microSDBContext )
        {
            _microSDBContext = microSDBContext;
        }


        public async Task<ComunaEntity> Add(ComunaEntity element)
        {
            await _microSDBContext.Comuna.AddAsync(element);
            await _microSDBContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _microSDBContext.Comuna.SingleAsync(x => x.IdCom == id);
            _microSDBContext.Comuna.Remove(entity);
            await _microSDBContext.SaveChangesAsync();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ComunaEntity> Get(int id)
        {
            var result = await _microSDBContext.Comuna.FirstOrDefaultAsync(x => x.IdCom == id);
            return result;
        }

        public async Task<IEnumerable<ComunaEntity>> GetAll()
        {
            return _microSDBContext.Comuna.Select(x => x);
        }

        public async Task<ComunaEntity> Update(int id, ComunaEntity element)
        {
            var entity = await Get(id);
            entity.nombre = element.nombre;
            _microSDBContext.Comuna.Update(entity);
            await _microSDBContext.SaveChangesAsync();
            return entity;
        }
    }
}
