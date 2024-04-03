using LegacyApp;

namespace LegacyAppTest;

public class UserServiceTests
{
    [Fact]
    public void Add_User_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        var service = new UserService();
        //Act
        bool result = service.AddUser("Tomasz", "Molak", "tomeczekUWU", new DateTime(1410, 7, 15), 7);
        //Assert
        Assert.Equal(false, result);
    }
}