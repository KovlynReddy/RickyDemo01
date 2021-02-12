using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickyDemo01.Database
{
    public interface IRickyRipository
    {
        Task<IEnumerable<AlphaUser>> GetUsersAsync();
        Task<IEnumerable<AlphaUser>> QueryUserAsync(Func<AlphaUser ,bool> predicate);
        Task<AlphaUser> GetUserByIdAsync(string id);
        Task<AlphaUser> GetUserByIdAsync(int id);
        Task<AlphaUser> AddUserAsync(AlphaUser user);
        Task<AlphaUser> UpdateUserAsync(AlphaUser user);
        Task<AlphaUser> DeleteUserAsync(AlphaUser user);
    }
}
