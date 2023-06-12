using System.Reflection;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.ViewModel;


namespace WebApplicationExam2023.ViewModel;

public class UserViewModel
{
    public Guid Id { get; set; }

    public string? UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }

    public static UserViewModel From(User user)
    {
        return new UserViewModel
        {
            Id = user.Id,
            UserName = user.UserName,
            FirstName = user.FirstName,
            Email = user.Email,
        };
    }


    public static UserViewModel From(Guid id, string username, string email, string firstName, string lastName, string title, string content) {
        return new UserViewModel
        {
            Id = id,
            UserName = username,
            FirstName = firstName,
            Email = email,
            Title = title,
            Content = content,

        };
            
            
     }
}
