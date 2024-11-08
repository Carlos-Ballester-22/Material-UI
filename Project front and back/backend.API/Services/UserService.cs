using backend.API.Models;
using backend.API.Repository;

namespace backend.API.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> DeleteUserAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<User> PostUserAsync(User user)
    {
        await _repository.CreateAsync(user);
        return user;
    }

    public async Task<User> PutUserAsync(User user)
    {
        await _repository.UpdateAsync(user);
        return user;
    }
}