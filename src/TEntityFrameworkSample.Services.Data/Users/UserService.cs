using System.Linq;
using TEntityFrameworkSample.Core;
using TEntityFrameworkSample.Core.Data;
using TEntityFrameworkSample.Core.Domain;
using TEntityFrameworkSample.Core.Domain.Users;
using TEntityFrameworkSample.Services.Users;

namespace TEntityFrameworkSample.Services.Data.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<CodeDic> _codeRepository;

        public UserService(IRepository<User> userRepository, IRepository<CodeDic> codeRepository)
        {
            _userRepository = userRepository;
            _codeRepository = codeRepository;
        }
        public void Add(User user)
        {
            _userRepository.Insert(user);
        }

        public IPagedList<UserInfo> GetAll(int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var query = from u in _userRepository.TableNoTracking
                        join c in _codeRepository.TableNoTracking on new { Type = 0, Key = u.CodeKey } equals new { c.Type, c.Key }
                        orderby u.CreateTime
                        select new UserInfo()
                        {
                            User = u,
                            CodeDic = c
                        };

            return new PagedList<UserInfo>(query, pageIndex, pageSize);
        }
    }
}
