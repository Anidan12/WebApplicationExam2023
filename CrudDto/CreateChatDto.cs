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
