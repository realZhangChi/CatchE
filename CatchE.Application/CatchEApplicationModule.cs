using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace CatchE;

[DependsOn(
    typeof(AbpDddApplicationModule),
    typeof(CatchEDomainModule))]
public class CatchEApplicationModule : AbpModule
{ }
