using Application.DTOs.Base;
using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RequestDTO
{
    public class UserDTOs : UserDTO
    {
        [MaxLength]
        public string UserName { get; set; } = String.Empty;
        public string UserEmail { get; set; } = String.Empty;
    [Phone]
        public string Phone { get; set; }= String.Empty;


        public string Password { get; set; } = String.Empty;
        public new string IsValid()
        {
            if (string.IsNullOrWhiteSpace(UserName))
                return "Name is Required";

            if (UserEmail == null)
                return "Customer Id Required";
            return  base.ToString();
        }


    }
}
