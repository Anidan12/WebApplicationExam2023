using Microsoft.AspNetCore.Mvc;
using WebApplicationExam2023.CrudDto;
using WebApplicationExam2023.Domain;
using WebApplicationExam2023.Domain.Models;
using WebApplicationExam2023.Service;
using WebApplicationExam2023.ViewModel;


namespace WebApplicationExam2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly NotificationStatus _notificationStatus;
        public UserController(NotificationStatus notificationStatus)
        {
            this._notificationStatus = notificationStatus;
        }

        private static User? FindUserById(Guid id)
        {
            return Database.Users.Find(x => x.Id == id);
        }


        //------------------
        [HttpGet]
        public UserViewModel[] GetAll(User user)
        {
            this._notificationStatus.Notify("Vis alle User....");
            return Database.Users.Select(User => UserViewModel.From(user)).ToArray();
        }


        //--------------- Get Users
        [HttpGet("{id:guid}")]
        public UserViewModel GetById(Guid id)
        {
            var user = Database.Users
                .First(x => x.Id == id);
            return UserViewModel.From(user);
        }



        //---------------
        [HttpGet("{id:guid}/chats")]

        public Chat[] Get(Guid id)
        {
            return Database.Chats.Where(x => x.UserId == id) .ToArray();

        }

        //---------------
        [HttpGet("{id:guid}/chats/amount")]

        public int Count(Guid id)
        {
            return Database.Chats.Count(x => x.UserId == id);
        }


        //--------

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDto createUserDto)
        {
            if (createUserDto.Password.Contains(createUserDto.Username))
            {
                ModelState.AddModelError("Password", "Dit brugernavn må ikke indgå i passwordet.");
            }

            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var account = new User
            {
                Id = Guid.NewGuid(),
                UserName = createUserDto.Username,
                Email = createUserDto.Email,
                Password = createUserDto.Password,
            };

            Database.Users.Add(account);

            return Ok(account.Id);
        }



        //--------------------------
        [HttpPut("{id:guid}")]

        public User Update(Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = FindUserById(id) ?? throw new Exception("User eksisterer ikke");
            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;

            return user;
        }



        //------------------------------------
        [HttpDelete("{id:guid}")]

        public bool Delete(Guid id, [FromBody] DeleteChatDto deleteChatDto)
        {
            var user = FindUserById(id);
            if (user == null)
            {
                throw new Exception("User eksisterer ikke så den kan ikke blive slettet");
            }
            
            else return Database.Users.Remove(user);
            {
                //Console.Write($"User er blevet slettet");
            }
        }
        

    }
}
