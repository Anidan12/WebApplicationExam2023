using Microsoft.AspNetCore.SignalR;
using WebApplicationExam2023.Domain.Models;
using WebApplicationExam2023.ViewModel;

namespace WebApplicationExam2023.Domain;

internal static class Database
{
    public static List<User> Users { get; set; } = new List<User>()
    {   
        //Ny Entity
        new User
        {
            Id = new Guid("bfca8bd7-44b8-4dba-bd79-7791b8abe66d"),
            UserName = "anidan",
            FirstName = "Anita",
            LastName = "Dantved",
            CreatedDate = DateTime.Now,
            Email = ("a_dantved@hotmail.com"),
            Password = "123abc",
        },

        
        new User
         {
            Id = new Guid("784bcb60-c719-4a01-a142-ee917da78299"),
            UserName = "monikaN12",
            FirstName = "Monika",
            LastName = "Nielsen",
            CreatedDate = DateTime.Now,
            Email = ("monikald@gmail.com"),
            Password = "321cba",
         },
            
    };

    public static List<Chat> Chats { get; set; } = new List<Chat>()
    {
        new Chat
        {
              Id = new Guid("fb248f6e-6c06-4511-a09a-303adb841148"),
              Title = "Lorem Ipsum Text",
              Content = "Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
              UserId = new Guid ("784bcb60-c719-4a01-a142-ee917da78299"),
              CreatedDate = DateTime.Now,
              LastModifiedDate = DateTime.Now,
        },
        
        
        new Chat
        {
              Id = new Guid("dd7c12d6-6045-42b3-8546-bf78b74a444c"),
              Title = " Is it a Dummy Text?",
              Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
              UserId = new Guid ("fb248f6e-6c06-4511-a09a-303adb841148"),
              CreatedDate = DateTime.Now,
              LastModifiedDate = DateTime.Now,
        },


    };
};
