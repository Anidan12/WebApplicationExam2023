using System.ComponentModel.DataAnnotations;
using WebApplicationExam2023.Controllers;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.ViewModel;
using WebApplicationExam2023.Service;

namespace WebApplicationExam2023.CrudDto
{
    public class CreatChatDto

    {
        public string? Content { get; set; }
        public Guid? ParentChatId { get; set; }
        public Guid? AuthorId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        public Guid OwnerId { get; set; }
    }
}
