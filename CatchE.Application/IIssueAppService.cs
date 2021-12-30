using Volo.Abp.Application.Services;

namespace CatchE;

public interface IIssueAppService : IApplicationService
{
    Task<IssueDto> CreateAsync(CreateIssueDto input);
}