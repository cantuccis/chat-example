using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserTest
    {
        private readonly string _validUsername = "cantuccis";
        private readonly string _lowerBoundInvalidUsername = "cant";
        private readonly string _upperBoundInvalidUsername = "cantucciscantucciscantuccis";
        
        private readonly string _validPassword = "password";
        private readonly string _lowerBoundInvalidPassword = "passwor";

        private readonly string _validEmail = "farancetiza@gmail.com";

        [TestInitialize]
        public void SetUpTest()
        {
            DateTimeProvider.Reset();
        }

        [TestMethod]
        public void NewUserTest()
        {
            var someUser = new User(username: _validUsername, password: _validPassword);
            Assert.IsNotNull(someUser, "User constructor with parameters should not return null");
        }

        [TestMethod]
        public void GetUsernameTest()
        {
            var someUser = new User(username: _validUsername, password: _validPassword, email: _validEmail);
            Assert.AreEqual(_validUsername, someUser.Username, $"User's username should be {_validUsername}");
        }

        [TestMethod]
        public void GetEmailTest()
        {
            var someUser = new User(username: _validUsername, password: _validPassword, email: _validEmail);
            Assert.AreEqual(_validEmail, someUser.Email, $"User's email should be {_validEmail}");
        }

        [TestMethod]
        public void SetEmailTest()
        {
            var someUser = new User(_validUsername, _validPassword)
            {
                Email = _validEmail, // Esto es lo mismo que crear el objeto someUser y luego hacer someUser.Email = _validEmail
            };
            Assert.AreEqual(_validEmail, someUser.Email, $"User's email should be {_validEmail}");
        }

        [TestMethod]
        public void GetDefaultCreationDateTest()
        {
            /*
            Cuando el test tiene varios pasos, ordenarlo por: Arrage, Act, Assert

            En este caso, queremos testear que la clase User se crea por defecto con la property 
            [CreationDate] valiendo DateTime.Now.
            La única forma de lograr esto es con intermediario que fije el valor de DateTime.Now.
            Así, se puede hacer un assert sobre la fecha y hora específica que la clase debería haber
            asignado en el constructor.
            */

            //Arrange
            DateTimeProvider.Now = DateTime.Now;
            var someUser = new User(_validUsername, _validPassword);

            //Act
            DateTime creationDate = someUser.CreationDate;

            //Assert
            Assert.AreEqual(DateTimeProvider.Now, creationDate, "Default creation date should be DateTime.Now");
        }

        [TestMethod]
        public void SetConstructorCreationDateTest()
        {
            //Arrange
            var someDate = DateTime.Now;

            //Act
            var someUser = new User(username: _validUsername, password: _validPassword)
            {
                CreationDate = someDate,
            };
            
            //Assert
            Assert.AreEqual(someDate, someUser.CreationDate, $"CreationDate should be {someDate}");
        }

        [TestMethod]
        public void CheckSamePasswordTest()
        {
            //Arrange
            var someUser = new User(username: _validUsername, password: _validPassword);

            //Act
            var isSamePassword = someUser.CheckPassword(_validPassword);
            
            //Assert
            Assert.IsTrue(isSamePassword, $"User's password should be {_validPassword}");
        }

        [TestMethod]
        public void CheckDifferentPasswordTest()
        {
            //Arrange
            var someUser = new User(username: _validUsername, password: _validPassword);

            //Act
            var isSamePassword = someUser.CheckPassword("notmypassword");

            //Assert
            Assert.IsFalse(isSamePassword, $"User's password should not match with {_validPassword}");
        }

        [TestMethod]
        public void SetLowerBoundInvalidUsernameTest()
        {
            /* Uso try catch para testear la excepcion en lugar de [ExpectedException]
             * porque quiero testear el mensaje que devuelve la exception.*/
            try
            {
                _ = new User(_lowerBoundInvalidUsername, _validPassword);
            }
            catch (DomainException ex)
            {
                Assert.AreEqual(ex.Message, "Username is too short (minumum length allowed is 5)");
            }
            catch (Exception)
            {
                Assert.Fail("Exception thrown is not a DomainException");
            }
        }

        [TestMethod]
        public void SetUpperBoundInvalidUsernameTest()
        {
            try
            {
                _ = new User(_upperBoundInvalidUsername, _validPassword);
            }
            catch (DomainException ex)
            {
                Assert.AreEqual(ex.Message, "Username is too long (maximum length is 27)");
            }
            catch (Exception)
            {
                Assert.Fail("Exception thrown is not a DomainException");
            }
        }

        [TestMethod]
        public void SetNullUsernameTest()
        {
            try
            {
                _ = new User(null, _validPassword);
            }
            catch (DomainException ex)
            {
                Assert.AreEqual(ex.Message, "Username is required");
            }
            catch (Exception)
            {
                Assert.Fail("Exception thrown is not a DomainException");
            }
        }

        [TestMethod]
        public void SetLowerBoundInvalidPasswordTest()
        {
            try
            {
                _ = new User(_validUsername, _lowerBoundInvalidPassword);
            }
            catch (DomainException ex)
            {
                Assert.AreEqual(ex.Message, "Password is too short (minimum length is 8)");
            }
            catch (Exception)
            {
                Assert.Fail("Exception thrown is not a DomainException");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException), "Password is required")]
        public void SetNullPasswordTest()
        {
            try
            {
                _ = new User(_validUsername, null);
            }
            catch (DomainException ex)
            {
                Assert.AreEqual(ex.Message, "Password is required");
            }
            catch (Exception)
            {
                Assert.Fail("Exception thrown is not a DomainException");
            }
        }


    }
}
