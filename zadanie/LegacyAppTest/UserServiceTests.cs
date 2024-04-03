using LegacyApp;

namespace LegacyAppTest;

public class UserServiceTests
{
    [Fact]
    public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        var service = new UserService();
        //Act
        bool result = service.AddUser("Tomasz", "Molak", "tomeczekUWU", new DateTime(1410, 7, 15), 7);
        //Assert
        Assert.Equal(false, result);
    }
    [Fact]
    public void AddUser_Should_Return_False_When_Missing_Firstname()
    {
        //Arrange
        var service = new UserService();
        //Act
        bool result = service.AddUser(null, "Malak", "tomeczek@UWU.pl", new DateTime(1410, 7, 15), 7);
        //Assert
        Assert.Equal(false, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Missing_Lastname()
    {
        //Arrange
        var service = new UserService();
        //Act
        bool result = service.AddUser("Tomek", null, "tomeczek@UWU.pl", new DateTime(1410, 7, 15), 7);
        //Assert
        Assert.Equal(false, result);
    }

    [Fact]
    public void AddUser_Should_Return_False_When_Younger_Than_21_Years_Old()
    {
        var service = new UserService();
        //Act
        bool result = service.AddUser("Tomek", null, "tomeczek@UWU.pl", new DateTime(2005, 7, 15), 7);
        //Assert
        Assert.Equal(false, result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Very_Important_Client()
    {
        var service = new UserService();
        //Act
        bool result = service.AddUser("Tomek", null, "tomeczek@UWU.pl", new DateTime(2005, 7, 15), 7);
        //Assert
        Assert.Equal(true, result);
    }
    
    
}