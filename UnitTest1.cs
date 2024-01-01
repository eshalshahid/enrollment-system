using NUnit.Framework;
using EnrollmentSystem;

[TestFixture]
public class LoginFormTests
{
    [Test]
    public void TestValidLogin()
    {
        // Arrange
        frmLogin loginForm = new frmLogin();

        // Act
        bool loginResult = loginForm.ValidateLogin("validUsername", "validPassword");

        // Assert
        Assert.IsTrue(loginResult, "Login with valid credentials should succeed");
    }

    [Test]
    public void TestInvalidLogin()
    {
        // Arrange
        frmLogin loginForm = new frmLogin();

        // Act
        bool loginResult = loginForm.ValidateLogin("invalidUsername", "invalidPassword");

        // Assert
        Assert.IsFalse(loginResult, "Login with invalid credentials should fail");
    }
}
