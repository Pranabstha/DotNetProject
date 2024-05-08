using System;
using System.Threading.Tasks;

namespace BislariumCW.Interfaces
{
    public interface IRepositoryManager
    {
        IUserAuthenticationRepository UserAuthentication { get; }
        // Additional repository properties can be added here for other entities

        Task SaveAsync();
    }
}
