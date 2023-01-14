using CryptoTunisia.MVC.Data.Context;
using CryptoTunisia.MVC.Models;

namespace CryptoTunisia.MVC.Data.Repository;

public interface IUserRepository : IRepository<User>
{
    public User GetUserByUserName(string userName);
}
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<User> GetAll()
    {
        var users = _context.Users.ToList();
        return users;
    }

    public User Get(int id)
    {
        var user = _context.Users.SingleOrDefault(user => user.Id == id);
        return  user;
    }
    
    public User GetUserByUserName(string userName)
    {
        var user = _context.Users.SingleOrDefault(user => user.UserName == userName);
        return  user;
    }

    public void Add(User entity)
    {
        _context.Users.Add(entity);
        _context.SaveChanges();
        
    }

    public void Update(User entity)
    {
        _context.Users.Update(entity);
        _context.SaveChanges();
    }

    public bool Remove(User entity)
    {
        var user = Get(entity.Id);
        if (user != null)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}