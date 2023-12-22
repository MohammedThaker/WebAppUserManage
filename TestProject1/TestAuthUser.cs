using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.service;
using Domain.IRepository;
using Moq;
using Xunit;
namespace Test_UserManagement
{
    public class TestAuthUser : Models
    {

        [Fact]
       
        public void Teat_Auth_Shuold_call_Repository_ReturnData()
        {
            //Arrange
            string name= "mohammed";
            string password = "123456";

            var _unitwork = new Mock<IBaseUnitOftWork>();
            _unitwork.Setup(unit => unit.authenticate.AuthenticateData(name,password)).Returns(user);
            var usertest = new AuthenticateSerivce(_unitwork.Object);

            //act
            var result = usertest.AuthenticateSerivces(name, password);

            //Assert
            Assert.True(result);

        }

    }
}
