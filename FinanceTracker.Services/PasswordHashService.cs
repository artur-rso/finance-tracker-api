using FinanceTracker.Services.Interfaces;

namespace FinanceTracker.Services
{
    public class PasswordHashService : IPasswordHashService
    {
        public string GetHash(string password)
        {
            // TODO: hash passwords using a random salt, after concatenating the password with a pepper
            throw new NotImplementedException();
        }

        public bool IsPasswordValid(string hash, string password)
        {
            throw new NotImplementedException();
        }
    }
}
