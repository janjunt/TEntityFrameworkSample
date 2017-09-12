using System;

namespace TEntityFrameworkSample.Core.Domain.Users
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int CodeKey { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
