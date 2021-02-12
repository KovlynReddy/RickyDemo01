using Microsoft.EntityFrameworkCore;
using RickyAppDLL.SQLConnection;
using RickyDemo01.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickyAppDLL.DataBase
{
    public class RickyRepository : IRickyRipository
    {
        private readonly RickyDBContextDLL _dbContext;

        public RickyRepository(string Path)
        {
            _dbContext = new RickyDBContextDLL(Path);
        }

        public async Task<AlphaUser> AddUserAsync(AlphaUser user)
        {
            try
            {
               var trackingState = await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();

                var isAdded = trackingState.State == EntityState.Added;
                var newuser = await _dbContext.Users.FindAsync(user.ID);

                return newuser;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public async Task<AlphaUser> DeleteUserAsync(AlphaUser user)
        {
            try
            {
                var foundUser = await _dbContext.Users.FindAsync(user.ID);

                return foundUser;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public async Task<AlphaUser> GetUserByIdAsync(string id)
        {
            try
            {

                var foundUser = await _dbContext.Users.FindAsync(id);

                return foundUser;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public async Task<AlphaUser> GetUserByIdAsync(int id)
        {
            //var foundUser = await _dbContext.Users.FindAsync(user.ID);

            //return foundUser;

            return null;
        }

        public async Task<IEnumerable<AlphaUser>> GetUsersAsync()
        {
            try
            {
                var users = await _dbContext.Users.ToListAsync();
                return users;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        public async Task<IEnumerable<AlphaUser>> QueryUserAsync(Func<AlphaUser, bool> predicate)
        {
            try
            {
                var users = _dbContext.Users.Where(predicate);
                return users;
            }
            catch (Exception  e)
            {

                return null;
            }
        }

        public async Task<AlphaUser> UpdateUserAsync(AlphaUser user)
        {
            try
            {
                var trackingState =  _dbContext.Users.Update(user);
                await _dbContext.SaveChangesAsync();

                var isAdded = trackingState.State == EntityState.Added;
                var newuser = await _dbContext.Users.FindAsync(user.ID);

                return newuser;
            }
            catch (Exception e)
            {

                return null;
            }
        }
    }
}
