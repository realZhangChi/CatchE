using CatchE.Issues;

using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CatchE;

public class IssueAppService : ApplicationService, IIssueAppService
{
    protected IssueManager IssueManager =>
        LazyServiceProvider.LazyGetRequiredService<IssueManager>();

    protected IRepository<Issue, Guid> IssueRepository =>
        LazyServiceProvider.LazyGetRequiredService<IRepository<Issue, Guid>>();

    public async Task<IssueDto> CreateAsync(CreateIssueDto input)
    {
        var issue = await IssueManager.CreateAsync(
            input.AnswererId,
            input.Title,
            input.Description);
        await IssueRepository.InsertAsync(issue);

        return ObjectMapper.Map<Issue, IssueDto>(issue);
    }
}