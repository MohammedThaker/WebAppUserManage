using Xunit;
using Domain.Entities;
using Moq;
using Domain.IRepository;
using Application.Interfaces;
using Application.service;
using Application.DTOs.RequestDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestProject1
{
  


    public class TastUser
    {



        UserDTOs UserDTOs = new UserDTOs
        {
            
            UserEmail = "m@m.com",
            UserName = "Mohammed",
            Phone = "771159921",
        };
        User User = new User
        {
            UserId=2,
           Email = "m@m.com",
            Name = "Mohammed",
            Phone = "771159921",


        };

        
        [Fact]
        public void Teat_POST_Shuold_call_Repository_AddEntity()
        {
            //Arrange


            var _unitwork =new Mock<IBaseUnitOftWork>();
            _unitwork.Setup(unit => unit.AddUsers.Add(User)).Returns(User);
            var usertest =new CreateUserService(_unitwork.Object);

            //act
            var result = usertest.CreateUser(UserDTOs);

            //Assert
         Assert.NotNull(result);
            Assert.True(result);

        }

        [Fact]
        public void Test_GET_Shuold_call_Repository_GetByID()
        {
            //Arrange
            var _unitwork = new Mock<IBaseUnitOftWork>();
            _unitwork.Setup(unit => unit.GetUserById.GetByIdi(22)).Returns(User);
            var usertest = new GetUserByIdService(_unitwork.Object);

            //Act
            var result = usertest.GetUser_ById(22);

            //Asssert
            _unitwork.Verify(r=>r.GetUserById.GetByIdi(22),Times.Once());
            Assert.NotNull(result);
            Assert.Equal(UserDTOs.UserName, result.Name);
            Assert.Equal(UserDTOs.Phone, result.Phone);


        }

        [Fact]
        public void test_Shuold_call_Repository_GetAll()
        {
            //Arrange
            var _unitwork = new Mock<IBaseUnitOftWork>();
            _unitwork.Setup(unit => unit.GetAllUser.GetAll()).Returns(GetTestRegistrations());
            var usertest = new GetAllUserSerivce(_unitwork.Object);

            //Act
            var result = usertest.GetUser_All();

            //Asssert

            _unitwork.Verify(r => r.GetAllUser.GetAll(), Times.Once());
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);

        }
        private static List<User> GetTestRegistrations()
        {
            var registrations = new List<User>();
            registrations.Add(new User()
            {
                UserId = 1,
                Name = "Tester1",
                Phone= "77110"
            });
            registrations.Add(new User()
            {
                UserId = 2,
                Name = "Tester2",
                Phone = "77111"
            });
            registrations.Add(new User()
            {
                UserId = 3,
                Name = "Tester3",
                Phone = "77112"
            });
            return registrations;
        }
        [Fact]
        public void Test_Update_POST_ReturnsViewResult_Update()
        {
            //Arrange
            
            var _unitwork = new Mock<IBaseUnitOftWork>();
            _unitwork.Setup(unit => unit.UpdateUser.Update(User)).Returns(User);

            var usertest = new UpdateUserService(_unitwork.Object);

            //act
            var result =  usertest.Update_User(User);
            Assert.NotNull(result);


        }


        [Fact]
        public void Test_Delete_POST_ReturnsViewResult_InValidModelState()
        {
            // Arrange
            int testId = 2;

            var mockRepo = new Mock<IBaseUnitOftWork>();
            mockRepo.Setup(repo => repo.DeleteUser.RemoveById(It.IsAny<int>()))
                   .Returns(User)
                   .Verifiable();

            var usertest = new DeleteUserServiceById(mockRepo.Object);

            // Act
            var result = usertest.RemoveById(testId);
            Assert.NotNull(result);
            Assert.True(result);
            mockRepo.Verify();
        }


    }
}