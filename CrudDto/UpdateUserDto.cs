using System.ComponentModel.DataAnnotations;
using WebApplicationExam2023.Controllers;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.ViewModel;
using WebApplicationExam2023.Service;

namespace WebApplicationExam2023.CrudDto;

public class UpdateUserDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Guid Id { get; set; }
}
