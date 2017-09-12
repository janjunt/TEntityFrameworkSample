using TEntityFrameworkSample.Core;
using TEntityFrameworkSample.Core.Domain.Users;

namespace TEntityFrameworkSample.Services.Users
{
    public interface IUserService
    {
        void Add(User user);

        IPagedList<UserInfo> GetAll(int pageIndex = 0, int pageSize = int.MaxValue);
    }
}
