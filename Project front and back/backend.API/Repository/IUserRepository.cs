using backend.API.Models;

namespace backend.API.Repository;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();  
    Task<User> GetByIdAsync(int id);      
    Task CreateAsync(User user);            
    Task<User> UpdateAsync(User user);     
    Task<bool> DeleteAsync(int id);     
}
