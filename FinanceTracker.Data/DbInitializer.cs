using FinanceTracker.Models;
using Microsoft.Extensions.Configuration;

namespace FinanceTracker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IConfiguration configuration, FinanceTrackerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            User user = new()
            {
                Email = configuration["MasterUser:Email"],
                Name = configuration["MasterUser:Name"],
                Password = configuration["MasterUser:Password"]
            };

            context.Users.Add(user);

            context.SaveChanges();
        }
    }
}
