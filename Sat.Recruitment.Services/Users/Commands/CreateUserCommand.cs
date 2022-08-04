using MediatR;
using Sat.Recruitment.Domain.Dtos;
using Sat.Recruitment.Domain.Forms;
using Sat.Recruitment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Services.Users.Commands
{
    public class CreateUserCommand : IRequest<User>
    {
        public string Name { get; }
        public string Email { get; }
        public string Address { get; }
        public string Phone { get; }
        public UserTypeEnum UserType { get; }
        public decimal Money { get;  }
        public string Password { get; }
        public CreateUserCommand(UserCreationForm user)
        {
            Name = user.Name;
            Email = user.Email;
            Address = user.Address;
            Phone = user.Phone;
            UserType = (UserTypeEnum) user.UserType;
            Money = Convert.ToDecimal(user.Money);
            Password = user.Password;
        }
    }
}