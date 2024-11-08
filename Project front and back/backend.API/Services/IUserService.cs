using backend.API.Models;

namespace backend.API.Service;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync (int id);
    Task<User> PostUserAsync (User user);
    Task<User> PutUserAsync (User user);
    Task<bool> DeleteUserAsync (int id);
}