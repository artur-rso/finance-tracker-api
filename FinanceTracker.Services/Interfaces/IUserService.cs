using FinanceTracker.Models;

namespace FinanceTracker.Services.Interfaces
{
    public interface IUserService
    {
        User GetById(int Id);
    }
}
