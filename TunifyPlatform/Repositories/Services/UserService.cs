using TunifyPlatform.Data;
using TunifyPlatform.Models;
using Microsoft.EntityFrameworkCore;
using TunifyPlatform.Repositories.Interfaces;

namespace TunifyPlatform.Repositories.Services
{
    public class UserService : IUser
    {

        private readonly TunifyDbContext _context;

        public UserService(TunifyDbContext context)
        {
            _context = context;
        }

        public async Task<Users> CreateUser(Users user)
        {
            try
            {

                _context.Users.Add(user);
                await _context.SaveChangesAsync();


            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);

            }

            return user;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            List<Users> allUsers = new List<Users>();
            try
            {
                allUsers = await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            return allUsers;
        }


        public async Task<Users> GetUserById(int userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                return user;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);      
                return null; 
            }
        }


        public async Task<Users> UpdateUser(int id, Users user)
        {
            try
            {
                var exsitingUser = await _context.Users.FindAsync(id);
                exsitingUser = user ;
                await _context.SaveChangesAsync();
                return exsitingUser;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public  async Task DeleteUser(int id)
        {
            try
            {
                var user = await GetUserById(id);
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }


    }
}
