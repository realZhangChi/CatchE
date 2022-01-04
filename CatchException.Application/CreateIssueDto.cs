using System.ComponentModel.DataAnnotations;

namespace CatchException;

public class CreateIssueDto
{
    [Required]
    public string Title { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    public Guid AnswererId { get; set; }
}