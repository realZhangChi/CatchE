using Volo.Abp.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CatchException;

[Route("api/issue")]
public class IssueController : AbpControllerBase
{
    protected IIssueAppService AppService =>
        LazyServiceProvider.LazyGetRequiredService<IIssueAppService>();

    [HttpPost]
    public Task<IssueDto> CreateAsync(CreateIssueDto input)
    {
        return AppService.CreateAsync(input);
    }
}