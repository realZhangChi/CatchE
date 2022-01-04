using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(AbpIdentityDomainModule))]
public class CatchEDomainModule : AbpModule
{ }