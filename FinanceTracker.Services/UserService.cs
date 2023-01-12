using FinanceTracker.Data;
using FinanceTracker.Models;
using FinanceTracker.Services.Interfaces;

namespace FinanceTracker.Services
{
    public class UserService : IUserService
    {
        private readonly FinanceTrackerContext _database;

        public UserService(FinanceTrackerContext database)
        {
            _database = database;
        }

        public User GetById(int Id)
        {
            return _database.Users.Find(Id);
        }
    }
}