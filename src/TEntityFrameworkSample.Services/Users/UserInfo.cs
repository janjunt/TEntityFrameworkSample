using TEntityFrameworkSample.Core.Domain;
using TEntityFrameworkSample.Core.Domain.Users;

namespace TEntityFrameworkSample.Services.Users
{
    public class UserInfo
    {
        public User User { get; set; }
        public CodeDic CodeDic { get; set; }
    }
}
