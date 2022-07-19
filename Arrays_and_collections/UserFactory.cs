namespace Arrays_and_collections;

public class UsersFactory
{
    public static List<User> CreateUsers(int usersCount)
    {
        var users = new List<User>();
        for (int i = 0; i < usersCount; i++)
        {
            users.Add(UserGenerator.CreateUser());
        }

        return users;
    }
}