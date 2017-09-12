using System.Data.Entity.ModelConfiguration;
using TEntityFrameworkSample.Core.Domain;

namespace TEntityFrameworkSample.Data.Mapping
{
    public class CodeDicMap : EntityTypeConfiguration<CodeDic>
    {
        public CodeDicMap()
        {
            ToTable("CodeDic");
            HasKey(e => e.Id);
        }
    }
}
