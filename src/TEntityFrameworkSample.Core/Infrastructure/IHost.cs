namespace TEntityFrameworkSample.Core.Infrastructure
{
    public interface IHost
    {

        /// <summary>
        /// 容器
        /// </summary>
        IHostContainer Container { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        void Initialize();
    }
}
