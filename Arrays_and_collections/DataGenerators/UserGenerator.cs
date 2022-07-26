using Bogus;

namespace Arrays_and_collections;

public class UserGenerator
{
    public static User CreateUser()
    {
        var fakeUser = new Faker<User>()
            .RuleFor(us => us.Id, f => f.Random.Int(User.minId, User.maxId))
            .RuleFor(us => us.Age, f => f.Random.Int(User.minAge, User.maxAge))
            .RuleFor(us => us.Name, f => f.Person.FullName)
            .RuleFor(us => us.Cart, f => CartGenerator.CreateCart());
        return fakeUser.Generate();
    }
}