using Volo.Abp.Domain.Entities.Auditing;

namespace CatchE.Answerers;

public class Answerer : FullAuditedAggregateRoot<Guid>
{
    public Guid IdentityUserId { get; set; }

    public string Name { get; set; }

    public Answerer(
        Guid id,
        Guid identityUserId,
        string name) : base(id)
    {
        IdentityUserId = identityUserId;
        Name = name;
    }
}