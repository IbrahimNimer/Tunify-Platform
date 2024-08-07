using TunifyPlatform.Models;

namespace TunifyPlatform.Repositories.Interfaces
{
    public interface IUser
    {

        Task<Users> CreateUser(Users user);
        Task<List<Users>> GetAllUsers();
        Task<Users> GetUserById(int userId);

        Task<Users> UpdateUser(int id, Users user);

        Task DeleteUser(int id);
    }
}
