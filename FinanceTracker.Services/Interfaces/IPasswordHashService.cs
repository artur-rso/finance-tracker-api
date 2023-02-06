namespace FinanceTracker.Services.Interfaces
{
    public interface IPasswordHashService
    {
        string GetHash(string password);
        bool IsPasswordValid(string hash, string password);
    }
}
