namespace TasksApi.Services.Logger
{
    public class LoggerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LoggerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILoggerService GetLogger(string whichLogger)
        {
            if (whichLogger=="file")
                return _serviceProvider.GetRequiredService<FileLoggerService>();
            if (whichLogger == "db")
                return _serviceProvider.GetRequiredService<DbLogger>();
            return _serviceProvider.GetRequiredService<ILoggerService>();
        }
    }
}
