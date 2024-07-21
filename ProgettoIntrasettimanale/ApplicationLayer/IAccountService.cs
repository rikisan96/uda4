namespace ApplicationLayer;



public interface IAccountService
{
    User Register(User Username);

    User? Login(string Username, string Password);

    User? GetByUsername(string Username);

    bool AddUserType(string Username, string UserType);

    bool RemoveUserType(string Username, string UserType); 

    List<User> GetAllUsers();

    List<string> GetAllUserType();


}

public class User
{

}