using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._15.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AuthenticationTests
    {
        [Test]
        public void LogIn_ValidUsernameAndPassword_ReturnTrue()
        {
            string username = "testuser";
            string password = "abc$123";

            var auth = GetAuthenticationAndSignUp(username, password);

            bool isSignedIn = auth.SignIn(username, password);

            Assert.That(isSignedIn, Is.True);
        }

        [Test]
        public void LogIn_InvalidUsername_ReturnFalse()
        {
            string username = "testuser";
            string password = "abc$123";

            var auth = GetAuthenticationAndSignUp(username, password);

            bool isSignedIn = auth.SignIn("unknown", password);

            Assert.That(isSignedIn, Is.False);
        }

        [Test]
        public void LogIn_InvalidPassword_ReturnFalse()
        {
            string username = "testuser";
            string password = "abc$123";

            var auth = GetAuthenticationAndSignUp(username, password);

            bool isSignedIn = auth.SignIn(username, "wrong_password");

            Assert.That(isSignedIn, Is.False);
        }

        private Authentication GetAuthenticationAndSignUp(string username,
            string password)
        {
            var auth = new Authentication();
            auth.SignUp(username, password);

            return auth;
        }
    }
}
