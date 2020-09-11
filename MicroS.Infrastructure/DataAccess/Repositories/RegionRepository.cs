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
    public class RegionRepository : IRegionRepository
    {

        private readonly IMicroSDBContext _microSDBContext;
        public RegionRepository(IMicroSDBContext microSDBContext )
        {
            _microSDBContext = microSDBContext;
        }


        public async Task<RegionEntity> Add(RegionEntity element)
        {
            await _microSDBContext.Region.AddAsync(element);
            await _microSDBContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _microSDBContext.Region.SingleAsync(x => x.IdReg == id);
            _microSDBContext.Region.Remove(entity);
            await _microSDBContext.SaveChangesAsync();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RegionEntity> Get(int id)
        {
            var result = await _microSDBContext.Region.FirstOrDefaultAsync(x => x.IdReg == id);
            return result;
        }

        public async Task<IEnumerable<RegionEntity>> GetAll()
        {
            return _microSDBContext.Region.Select(x => x);
        }

        public async Task<RegionEntity> Update(int id, RegionEntity element)
        {
            var entity = await Get(id);
            entity.nombre = element.nombre;
            _microSDBContext.Region.Update(entity);
            await _microSDBContext.SaveChangesAsync();
            return entity;
        }
    }
}
