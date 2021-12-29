using Volo.Abp.Domain;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace CatchE;

[DependsOn(
    typeof(AbpIdentityDomainModule))]
public class CatchEDomainModule : AbpModule
{ }