using System;
using System.Threading.Tasks;

namespace BislariumCW.Interfaces
{
    public interface IRepositoryManager : IDisposable
    {
        IUserAuthenticationRepository UserAuthenticationRepository { get; }
        // Additional repository properties can be added here for other entities

        Task<int> SaveChangesAsync();
    }
}
