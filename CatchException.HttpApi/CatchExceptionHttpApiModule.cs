using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace CatchException;

[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(CatchExceptionApplicationModule))]
public class CatchExceptionHttpApiModule : AbpModule
{ }