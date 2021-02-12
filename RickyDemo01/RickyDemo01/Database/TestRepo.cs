using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickyDemo01.Database
{
    public class TestRepo : IRickyRipository
    {
        public List<AlphaUser> Users { get; set; } = new List<AlphaUser>();
        public TestRepo()
        {
            Users = new List<AlphaUser>{ 
            new AlphaUser { UserName = "Test 1" , Email ="test1@gmail.com" , ID = 1 , Password = "12345"},
            new AlphaUser { UserName = "Test 2" , Email ="test2@gmail.com" , ID = 2 , Password = "12345"},
            new AlphaUser { UserName = "Test 3" , Email ="test3@gmail.com" , ID = 3 , Password = "12345"},
            new AlphaUser { UserName = "Test 4" , Email ="test4@gmail.com" , ID = 4 , Password = "12345"}
            };
        }
        public async Task<AlphaUser> AddUserAsync(AlphaUser user)
        {
            Users.Add(user);
            return user;
        }

        public async Task<AlphaUser> DeleteUserAsync(AlphaUser user)
        {
            Users.Remove(user);
            return user;
        }

        public async Task<AlphaUser> GetUserByIdAsync(string id)
        {
            var user = Users.Find(u => u.Email == id);
            return user;
        }

        public async Task<AlphaUser> GetUserByIdAsync(int id)
        {
            var user = Users.Find(u => u.ID == id);
            return user;
        }

        public async Task<IEnumerable<AlphaUser>> GetUsersAsync()
        {
            return Users;
        }

        public async Task<IEnumerable<AlphaUser>> QueryUserAsync(Func<AlphaUser, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<AlphaUser> UpdateUserAsync(AlphaUser user)
        {
            throw new NotImplementedException();
        }
    }
}
