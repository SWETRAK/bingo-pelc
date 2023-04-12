using BingoPelc.Entities;

namespace BingoPelc.Repositories.Interfaces;

public interface IUserRepository: IDisposable
{
    Task<User> GetById(Guid userId);
    Task<User> GetByEmail(string email);
    Task InsertUser(User user);
    void DeleteUser(User user);
    void UpdateUser(User user);
    Task Save();
}