using Microsoft.AspNetCore.Mvc;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.Domain.Models;
using WebApplicationExam2023.CrudDto;


namespace WebApplicationExam2023.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        public static User? FindUserById(Guid? id)
        {
            return Database.Users.Find(x => x.Id == id);
        }


        //------------ Get all chats
        [HttpGet]
        public Chat[] GetAll()
        {
            return Database.Chats.ToArray();
        }


        //---------- Create new Chats
        [HttpPost]
        public Guid Create([FromBody] CreatChatDto createChatDto)
        {
            var user = Database.Users.Find(x => x.Id == createChatDto.OwnerId) ?? throw new Exception("Der er ingen User");
            var chat = new Chat
            {
                Id = Guid.NewGuid(),
                Content = createChatDto.Content,
                UserId = createChatDto.OwnerId,
                ParentChatId = createChatDto.ParentChatId,
            };

            Database.Chats.Add(chat);
            return chat.Id;
        }
        

        //----------- Update 
        [HttpPut("{id:guid}")]
        public Chat Update(Guid id, [FromBody] UpdateChatDto updateChatDto)
        {
            var chat = FindChatById(id) ?? throw new Exception("Chatten du vil finde eksisterer ikke");
            chat.Content = updateChatDto.Content;
            return chat;
        }


        //----------- Delete 
        [HttpDelete("{id:guid}")]
        public bool Delete(Guid id)
        {
            var chat = FindChatById(id);
            if (chat == null)
            {
                throw new Exception("Chatten du vil finde eksisterer ikke");
            }

            return Database.Chats.Remove(chat);
        }

        static Chat FindChatById(Guid id)
        {
            return Database.Chats.FirstOrDefault(x => x.Id == id);
        }
    }
}


