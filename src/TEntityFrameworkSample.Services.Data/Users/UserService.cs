using System.Linq;
using TEntityFrameworkSample.Core;
using TEntityFrameworkSample.Core.Data;
using TEntityFrameworkSample.Core.Domain.Users;
using TEntityFrameworkSample.Services.Users;

namespace TEntityFrameworkSample.Services.Data.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(User user)
        {
            _userRepository.Insert(user);
        }

        public IPagedList<User> GetAll(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = _userRepository.Table.OrderByDescending(u => u.CreateTime);

            return new PagedList<User>(query, pageIndex, pageSize);
        }
    }
}
