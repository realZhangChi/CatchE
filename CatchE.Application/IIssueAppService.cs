using Volo.Abp.Application.Services;

namespace CatchException;

public interface IIssueAppService : IApplicationService
{
    Task<IssueDto> CreateAsync(CreateIssueDto input);
}