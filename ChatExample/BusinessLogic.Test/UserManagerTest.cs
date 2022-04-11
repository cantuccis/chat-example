using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserManagerTest
    {
        private User someUser;

        [TestInitialize]
        public void SetUpTest()
        {
            someUser = new User(username: "cantuccis", password: "somepass");
        }

        [TestMethod]
        public void SignUpUserTest()
        {
            //Arrange
            var userManager = new UserManager();
            
            //Act
            userManager.SignUp(username: "cantuccis", password: "somepass");

            //Assert
            Assert.IsTrue(userManager.IsSignedUp(someUser.Username));   
        }

        [TestMethod]
        public void SignUpAlreadyExistentUserTest()
        {
            //Arrange
            var userManager = new UserManager();

            //Act
            try
            {
                userManager.SignUp(username: "cantuccis", password: "somepass");
                userManager.SignUp(username: "cantuccis", password: "somepass");
            }
            //Assert
            catch (DomainException ex)
            {
                Assert.AreEqual("User already exists", ex.Message, "Exception message mismatch");
            }
            catch (Exception)
            {
                Assert.Fail("Exception type mismatch");
            }
        }

        [TestMethod]
        public void SignInTest()
        {
            //Arrange
            var userManager = new UserManager();
            userManager.SignUp(username: "cantuccis", password: "somepass");

            //Act
            User credential = userManager.SignIn(username: "cantuccis", password: "somepass");

            //Assert
            Assert.AreEqual(someUser, credential);
        }

        [TestMethod]
        public void WrongPasswordSignInTest()
        {
            //Arrange
            var userManager = new UserManager();
            userManager.SignUp(username: "cantuccis", password: "somepass");
            
            //Act
            try
            {
                _ = userManager.SignIn(username: "cantuccis", password: "notsomepass");
            }
            //Assert
            catch (DomainException ex)
            {
                Assert.AreEqual("Invalid credentials", ex.Message, "Exception message mismatch");
            }
            catch(Exception)
            {
                Assert.Fail("Exception type mismatch");
            }
            
        }

        [TestMethod]
        public void WrongUsernameSignInTest()
        {
            //Arrange
            var userManager = new UserManager();
            userManager.SignUp(username: "cantuccis", password: "somepass");

            //Act
            try
            {
                _ = userManager.SignIn(username: "notcantuccis", password: "somepass");
            }
            //Assert
            catch (DomainException ex)
            {
                Assert.AreEqual("Invalid credentials", ex.Message, "Exception message mismatch");
            }
            catch (Exception)
            {
                Assert.Fail("Exception type mismatch");
            }

        }
    }
}
