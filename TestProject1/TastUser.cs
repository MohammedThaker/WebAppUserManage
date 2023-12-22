using Xunit;
using Domain.Entities;
using Moq;
using Domain.IRepository;
using Application.Interfaces;
using Application.service;
using Application.DTOs.RequestDTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test_UserManagement;

namespace TestProject1
{
  


    public class TastUser: Models
    {
        public readonly Mock<IBaseUnitOftWork> mock;
        public TastUser()
        {
        mock= new Mock<IBaseUnitOftWork>();
        }

        [Fact]
        public void Teat_POST_Shuold_call_Repository_AddEntity()
        {
            //Arrange



            mock.Setup(unit => unit.AddUsers.Add(user)).Returns(user);
            var usertest =new CreateUserService(mock.Object);

            //act
            var result = usertest.CreateUser(userDTOs);

            //Assert
         Assert.NotNull(result);
            Assert.True(result);

        }

        [Fact]
        public void Test_GET_Shuold_call_Repository_GetByID()
        {
            //Arrange
            int id =22;
            mock.Setup(unit => unit.GetUserById.GetByIdi(id)).Returns(user);
            var usertest = new GetUserByIdService(mock.Object);

            //Act
            var result = usertest.GetUser_ById(id);

            //Asssert
            mock.Verify(r=>r.GetUserById.GetByIdi(id),Times.Once());
            Assert.NotNull(result);
            Assert.Equal(userDTOs.UserName, result.Name);
            Assert.Equal(userDTOs.Phone, result.Phone);


        }

        [Fact]
        public void test_Shuold_call_Repository_GetAll()
        {
            //Arrange

            mock.Setup(unit => unit.GetAllUser.GetAll()).Returns(GetTestRegistrations());
            var usertest = new GetAllUserSerivce(mock.Object);

            //Act
            var result = usertest.GetUser_All();

            //Asssert

            mock.Verify(r => r.GetAllUser.GetAll(), Times.Once());
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);

        }
       
        [Fact]
        public void Test_Update_POST_ReturnsViewResult_Update()
        {
            //Arrange
            
         
            mock.Setup(unit => unit.UpdateUser.Update(user)).Returns(user);

            var usertest = new UpdateUserService(mock.Object);

            //act
            var result =  usertest.Update_User(user);
            Assert.NotNull(result);


        }


        [Fact]
        public void Test_Delete_POST_ReturnsViewResult_InValidModelState()
        {
            // Arrange
            int testId = 2;


            mock.Setup(repo => repo.DeleteUser.RemoveById(It.IsAny<int>()))
                   .Returns(user)
                   .Verifiable();

            var usertest = new DeleteUserServiceById(mock.Object);

            // Act
            var result = usertest.RemoveById(testId);
            Assert.NotNull(result);
            Assert.True(result);
            mock.Verify();
        }


    }
}