using TasksApi.Models;

namespace TasksApi.Services.Logger
{
    public class DbLogger : ILoggerService
    {
        private readonly TasksDbContext _tasksDbContext;

        public DbLogger(TasksDbContext tasksDbContext)
        {
            _tasksDbContext = tasksDbContext;
        }
        public void Log(string message)
        {
            Message m = new Message();
            m.message = message;
            try
            {
                _tasksDbContext.Message.Add(m);
                _tasksDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed to db message: {ex.Message}");
            }
        }
    }
}
