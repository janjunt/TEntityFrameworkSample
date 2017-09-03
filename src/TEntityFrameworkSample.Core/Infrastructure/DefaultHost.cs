using System;

namespace TEntityFrameworkSample.Core.Infrastructure
{
    public class DefaultHost : IHost
    {
        public IHostContainer Container { get; set; }

        public void Initialize()
        {
        }
    }
}
