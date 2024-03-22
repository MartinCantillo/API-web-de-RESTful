using ModelsUser.User;

namespace RepositoriesUserRepository.UserRepository;

public interface IUserRepository
{
    public Task<IEnumerable<User>> GetAll();
    public Task<User> GetUserById(int id);
    public Task DeleteUser(int id);
    public Task AddUser(User user);
    public Task UpdateUser(User user);


}