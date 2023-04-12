using BingoPelc.Repositories.Interfaces;

namespace BingoPelc.Repositories;

public class DailyBingoRepository: IDailyBingoRepository
{
    private readonly DomainContextDb _contextDb;
    private bool _disposed = false;

    public DailyBingoRepository(DomainContextDb contextDb)
    {
        _contextDb = contextDb;
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