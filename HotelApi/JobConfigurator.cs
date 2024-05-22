using Data.Interfaces;
using Hangfire;

namespace HotelApi
{
    public class JobConfigurator
    {
        /*
        public static void AddJobs()
        {
            RemoveExpiredTokensJob();
        }

        
        public static void RemoveExpiredTokensJob()
        {
            RecurringJob.AddOrUpdate<IAccountsService>(
                nameof(RemoveExpiredTokensJob),
                (service) => service.RemoveExpiredRefreshTokens(),
                Cron.Weekly(DayOfWeek.Monday, 3));
        }
        */
    }
}
