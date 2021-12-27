using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CatchE;

[DependsOn(
    typeof(AbpDddDomainModule))]
public class CatchEDomainModule : AbpModule
{ }