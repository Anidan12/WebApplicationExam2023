using WebApplicationExam2023.Controllers;
namespace WebApplicationExam2023.Domain;

public class User
{
    public Guid Id { get; set; }
    public string? UserName { get; set; } = null!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }    
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public Guid ChatId { get; set; }
}