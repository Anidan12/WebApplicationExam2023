using WebApplicationExam2023.Controllers;
namespace WebApplicationExam2023.Domain.Models;

public class Chat
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public Guid? ParentChatId { get; set; }
    public DateTime? CreatedDate { get; internal set; } = DateTime.Now;
    public DateTime? LastModifiedDate { get; internal set; } = DateTime.Now;
    public Guid UserId { get; set; }
 
}

