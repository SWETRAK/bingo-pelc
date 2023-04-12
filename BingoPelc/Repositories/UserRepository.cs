using BingoPelc.Entities;
using BingoPelc.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;

namespace BingoPelc.Repositories;

public class UserRepository: IUserRepository
{
    private readonly DomainContextDb _contextDb;
    private bool _disposed = false;

    public UserRepository(DomainContextDb contextDb)
    {
        _contextDb = contextDb;
    }

    public async Task<User> GetById(Guid userId)
    {
        return await _contextDb.Users.FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task<User> GetByEmail(string email)
    {
        return await _contextDb.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task InsertUser(User user)
    { 
        await _contextDb.Users.AddAsync(user);
    }

    public void DeleteUser(User user)
    {
        _contextDb.Users.Remove(user);
    }

    public void UpdateUser(User user)
    {
        _contextDb.Users.Update(user);
    }

    public async Task Save()
    {
        await _contextDb.SaveChangesAsync();
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _contextDb.Dispose();
            }
        }
        this._disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}