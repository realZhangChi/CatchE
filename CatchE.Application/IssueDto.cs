using Volo.Abp.Application.Dtos;

namespace CatchE;

public class IssueDto : EntityDto<Guid>
{
    public string Title { get; set; }

    public string Description { get; set; }

    public Guid? AnswererId { get; set; }

    public bool IsResolved { get; set; }
}