
using WebApplicationExam2023.Controllers;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.ViewModel;
using WebApplicationExam2023.Service;

namespace WebApplicationExam2023.CrudDto;

public class UpdateChatDto
{ 
    public string Content { get; set; } = null!;
    public Guid Id { get; set; }

}
