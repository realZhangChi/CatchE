using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(CatchEDomainModule))]
public class CatchEApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<CatchEApplicationModule>();
        });
    }
}
