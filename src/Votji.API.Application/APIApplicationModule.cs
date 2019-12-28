using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Votji.API.Authorization;

namespace Votji.API
{
    [DependsOn(
        typeof(APICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class APIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<APIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(APIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
