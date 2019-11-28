using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cm44.DailyH.Authorization;

namespace cm44.DailyH
{
    [DependsOn(
        typeof(DailyHCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DailyHApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DailyHAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DailyHApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
