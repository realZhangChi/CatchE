using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchE.Issues;

public class Answer : AuditedEntity<Guid>
{
    public Guid IssueId { get; init; }

    public string Content { get; private set; }

    public virtual Issue Issue { get; set; }

    private Answer()
    {

    }

    public Answer(
        Guid id,
        Guid issueId,
        string content) : base(id)
    {
        IssueId = issueId;
        Content = Check.NotNullOrWhiteSpace(content, nameof(content));
    }

    public Answer Change(string content)
    {
        Content = Check.NotNullOrWhiteSpace(content, nameof(content));

        return this;
    }
}