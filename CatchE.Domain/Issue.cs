using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchE;

public class Issue : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; private set; }

    public string Description { get; private set; }

    public Guid? AnswererId { get; private set; }

    public bool IsResolved { get; private set; }

    public virtual Answer Answer { get; set; }

    private Issue()
    {

    }

    public Issue(
        Guid id,
        string title,
        string description) : base(id)
    {
        Title = Check.NotNullOrWhiteSpace(title, nameof(title));
        Description = Check.NotNullOrWhiteSpace(description, nameof(description));
    }

    public Issue AssignTo(Guid answererId)
    {
        if (AnswererId.HasValue)
        {
            throw new BusinessException(message: "不可重复指派");
        }

        AnswererId = answererId;
        return this;
    }

    public Issue CancelAssign()
    {
        AnswererId = null;

        return this;
    }

    public Issue Resolved()
    {
        IsResolved = true;

        return this;
    }
}