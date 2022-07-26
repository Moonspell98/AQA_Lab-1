namespace Arrays_and_collections;

public class User
{
    public static int minId = 1000;
    public static int maxId = 9999;
    public static int minAge = 3;
    public static int maxAge = 130;
    public static int ageOfMajority = 18;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Cart Cart { get; set; }

    public override bool Equals(object? obj)
    {
        var otherUser = obj as User;
        return otherUser.Id.Equals(Id);
    }
}