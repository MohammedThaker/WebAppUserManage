using Application.DTOs.RequestDTO;
using Application.DTOs.ResponseDTO;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/CusomerOrder")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        public readonly IGetUserByIdService getUserByIdService;
        public readonly IGetAllUserSerivce getAllUserSerivce;
        public readonly ICreateUserSerivce createUserSerivce;
        public readonly IUpdateUserService  updateUserService;
        public readonly IDeleteUserServiceById deleteUserServiceById;

        public UserManagementController(IGetUserByIdService getUserByIdService, IGetAllUserSerivce getAllUserSerivce, ICreateUserSerivce createUserSerivce, IUpdateUserService updateUserService,
            IDeleteUserServiceById deleteUserServiceById)
        {
            this.getUserByIdService = getUserByIdService;
            this.getAllUserSerivce = getAllUserSerivce;
            this.createUserSerivce = createUserSerivce;
            this.updateUserService = updateUserService;
            this.deleteUserServiceById = deleteUserServiceById;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var Users = getAllUserSerivce.GetUser_All();

                if (Users == null)
                    return NotFound(" Invalid Users");
                return Ok(Users);
            }

            catch (Exception)
            {
                return NotFound(" Invalid User");

            }

        }



        [HttpGet("{Id}")]
        public IActionResult GetUserById(int Id)
        {
            try
            {

                var User = getUserByIdService.GetUser_ById(Id);

                var UserDTOs = new UserDTOs
                {
                    Phone = User.Phone,
                    UserName=User.Name,
                    UserEmail=User.Email,

                    
                 };
 
                if (User == null)
                    return NotFound(" Invalid User Id");

                return Ok(UserDTOs);

            }
            catch (Exception )
            {
                return NotFound("Invalid Order");

            }

        }

        [HttpPost]
        public IActionResult PostUser([FromBody] UserDTOs NewUser)
        {


            try
            {

                if (string.IsNullOrWhiteSpace(NewUser.UserName))
                    return NotFound("يرجى ادخال الاسم");
                if (string.IsNullOrEmpty(NewUser.UserEmail))
                    return NotFound("يرجى ادخال الايميل ");
                if (string.IsNullOrEmpty(NewUser.Password))
                    return NotFound("يرجى ادخال كلمة السر ");





                var User = new User()
                {
                    Name = NewUser.UserName,
                    Email = NewUser.UserEmail,

                    Phone = NewUser.Phone,
                    Password = NewUser.Password

                };
                var user = createUserSerivce.CreateUser(User);
                if (user == true)
                    return Ok("تمت الاضافة بنجاح");
                else return BadRequest("لم يتم الاضافة");


            }catch (Exception)
            {
                return NotFound("Invalid Order");

            }
            
            
            }







    }
}
