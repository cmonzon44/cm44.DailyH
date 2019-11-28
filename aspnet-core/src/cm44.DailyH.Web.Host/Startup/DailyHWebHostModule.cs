using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cm44.DailyH.Configuration;

namespace cm44.DailyH.Web.Host.Startup
{
    [DependsOn(
       typeof(DailyHWebCoreModule))]
    public class DailyHWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DailyHWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DailyHWebHostModule).GetAssembly());
        }
    }
}
