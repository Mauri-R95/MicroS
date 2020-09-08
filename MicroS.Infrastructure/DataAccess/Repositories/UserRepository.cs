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
    public class UserRepository : IUserRepository
    {

        private readonly IMicroSDBContext _microSDBContext;
        public UserRepository(IMicroSDBContext microSDBContext )
        {
            _microSDBContext = microSDBContext;
        }


        public async Task<UserEntity> Add(UserEntity element)
        {
            await _microSDBContext.User.AddAsync(element);
            await _microSDBContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _microSDBContext.User.SingleAsync(x => x.IdUser == id);
            _microSDBContext.User.Remove(entity);
            await _microSDBContext.SaveChangesAsync();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Get(int id)
        {
            var result = await _microSDBContext.User.FirstOrDefaultAsync(x => x.IdUser == id);
            return result;
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return _microSDBContext.User.Select(x => x);
        }

        public async Task<UserEntity> Update(int id, UserEntity element)
        {
            var entity = await Get(id);
            entity.Nombre = element.Nombre;
            _microSDBContext.User.Update(entity);
            await _microSDBContext.SaveChangesAsync();
            return entity;
        }
    }
}
