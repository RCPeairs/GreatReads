using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Xunit;
using Constant;
using DataService;
using Entities;
using Repositories;

namespace SqlWrite.Test
{
    [TestClass]
    public class TestWriteUser
    {
        private User MakeTestRecord()
        {
            User vtestRecord = new User
            {
                Id = 0
                , UserName = "UnitTestUser"
                , Password = "123"
                , FirstName = "Unit"
                , LastName = "Test"
                , StreetAddress = "123 AnyStreet"
                , City = "AnyTown"
                , State = "AZ"
                , Zip = "85248"
                , Email = "UnitTestUser@Gmail.Com"
                , Phone = "123-4567"
                , Avatar = "Cliffs"
                , AdminNotes = "This is an admin note."
                , Administrator = false
                ,Member = true
                ,PendingMember = false
                ,TextNewMember = true
                ,TextNewActivity = false
                ,TextChangeMyActivity = true
                ,TextNewBook = false
                ,TextNewBBPost = true
                ,EmailNewMember = false
                ,EmailNewActivity = true
                ,EmailChangeMyActivity = false
                ,EmailNewBook = true
                ,EmailNewBBPost = false
            };

            return vtestRecord;
        }

        //[TestMethod]
        [Fact]
        public void TestAddUser()
        {
            // Arrange
            IUserR vrepository = new UserR();
            User vuser = MakeTestRecord();

            // Act
            int vreturnCode = vrepository.AddUser(vuser);

            // Assert
            vreturnCode.Should().Be(Constants.successCode);
        }
    }
}
