using System.Data.Entity.ModelConfiguration;
using TEntityFrameworkSample.Core.Domain.Users;

namespace TEntityFrameworkSample.Data.Mapping.Users
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");
            HasKey(u => u.Id);
            Property(u => u.Name).HasMaxLength(80).IsRequired();
        }
    }
}
