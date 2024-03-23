using DataContext.Context;
using ModelsUser.User;
using RepositoriesUserRepository.UserRepository;
using Microsoft.EntityFrameworkCore; // importacion de entity framework core

namespace ServicesUserService.UserService
{
    public class UserService : IUserRepository
    {
        private readonly BDContext _context;

        public UserService(BDContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var userFound = await _context.Users.FindAsync(id);
            if (userFound != null)
            {
                _context.Users.Remove(userFound);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
