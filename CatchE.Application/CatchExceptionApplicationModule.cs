using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(CatchEDomainModule))]
public class CatchExceptionApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CatchExceptionApplicationModule>();
        });
    }
}
