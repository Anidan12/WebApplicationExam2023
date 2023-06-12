
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.Controllers;
using WebApplicationExam2023.ViewModel;
using WebApplicationExam2023.Service;

namespace WebApplicationExam2023.CrudDto
{
    public class CreateUserDto
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;


    }
}
