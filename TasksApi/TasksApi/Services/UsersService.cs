using TasksApi.Models;
using TasksApi.Repository;
using TasksApi.Services.Logger;

namespace TasksApi.Services
{
    public class UsersService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoggerService _logger;

        private readonly Services.Logger.LoggerFactory _loggerFactory;

        public UsersService(IUserRepository userRepository,Services.Logger.LoggerFactory loggerFactory)
        {
            _userRepository = userRepository;
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.GetLogger(true);
        }
        public bool CreateUser(TasksUser user)
        {
            

            _logger.Log($"Create User start:{user.UserId}");
            return _userRepository.ProcessTransaction(user.FirstName, "test title");
        }
    }
}
