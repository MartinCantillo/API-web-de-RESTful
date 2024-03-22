using System.Data.Entity;
using DataContext.Context;
using ModelsUser.User;
using RepositoriesUserRepository.UserRepository;

namespace ServicesUserService.UserService;

public class UserService : IUserRepository
{
    private readonly BDContext _context;
    //Constructor e inyeccion de dependencia del contexto
    public UserService(BDContext _context)
    {
        this._context = _context;
    }

    public async Task AddUser(User user)
    {

        await this._context.Users.AddAsync(user); //Se guarda en el contexto mas no en la bd
        await this._context.SaveChangesAsync();//Aqui si se guarda en la bd (guarda todos los que esten en el contexto)
    }

    public async Task DeleteUser(int id)
    {
        var userFound = await this._context.Users.FindAsync(id);
        if (userFound != null)
        {//Elimino el usuario del contexto
            this._context.Users.Remove(userFound);
            //Actualizo el contexto de la bd
            await this._context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        //obtener todos del contexto
        return await this._context.Users.ToListAsync();
    }

    public async Task<User?> GetUserById(int id)
    {
        return await this._context.Users.FindAsync(id);
    }

    public async Task UpdateUser(User user)
    {
        // Actualizar el usuario en el contexto
        this._context.Users.Update(user);
        // Guardar los cambios en la base de datos
        await this._context.SaveChangesAsync();
    }
}