using CatchE.Answerers;

using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Identity;

namespace CatchE.Issues;

public class IssueManager : DomainService
{
    protected IRepository<Answerer, Guid> AnswererRepository =>
        LazyServiceProvider.LazyGetRequiredService<IRepository<Answerer, Guid>>();

    protected IRepository<IdentityUser, Guid> IdentityUserRepository =>
        LazyServiceProvider.LazyGetRequiredService<IRepository<IdentityUser, Guid>>();

    public async Task<Issue> CreateAsync(
        Guid answererIdentityUserId,
        string title,
        string description)
    {
        var answerer = await AnswererRepository
            .SingleOrDefaultAsync(a => a.IdentityUserId == answererIdentityUserId);
        if (answerer is null)
        {
            var userExists = await IdentityUserRepository
                .AnyAsync(u => u.Id == answererIdentityUserId);
            if (!userExists)
            {
                throw new UserFriendlyException("用户不存在");
            }

            answerer = await AnswererRepository.InsertAsync(
                new Answerer(
                    GuidGenerator.Create(),
                    answererIdentityUserId));
        }

        var issue = new Issue(
            GuidGenerator.Create(),
            title,
            description);
        issue.AssignTo(answerer);

        return issue;
    }
}