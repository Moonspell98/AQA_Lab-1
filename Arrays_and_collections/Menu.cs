namespace Arrays_and_collections;

public class Menu
{
    public List<User> _users;
    public Menu(List<User> users)
    {
        _users = users;
    }
    public void ShowMenu()
    {
        int choice = 0;
        Console.WriteLine("1. Show all users");
        Console.WriteLine("2. Add user");
        Console.WriteLine("3. Exit");
        choice = NumberValidator.Validate(1, 3, "Please, select option");
        if (choice == 1)
        {
            ShowAllUsers(_users);
            ShowUserCart(_users);
        }
        else if (choice == 2)
        {
            AddUser(_users);
        }
        {
            
        }
    }
    public void ShowAllUsers(List<User> users)
    {
        int usersCounter = 0;
        Console.WriteLine("| {0,7} | {1, 7} | {2, 25} | {3, 8} | {4, 9} |", "User #", "User Id", "User Name",
            "User Age", "Cart Sum");
        foreach (var user in users)
        {
            usersCounter++;
            Console.WriteLine("| {0,7} | {1, 7} | {2, 25} | {3, 8} | {4, 9} |", usersCounter, user.Id, user.Name,
                user.Age, user.Cart.CountPriceSum());
        }
    }

    public void ShowUserCart(List<User> users)
    {
        int chosenUser = NumberValidator.Validate(1, users.Count, "Please, select user (enter user's #)");
        Console.WriteLine(users[chosenUser - 1].Name + "'s cart contains");
        Console.WriteLine("| {0,17} | {1, 11} | {2, 25} | {3, 8} |", "Product Category", "Product Id", "Product Name", "Price");
        foreach (var product in users[chosenUser - 1].Cart.products)
        {
            Console.WriteLine("| {0,17} | {1, 11} | {2, 25} | {3, 8} |", product.Category, product.Id, product.Name, product.Price);
        }
    }

    public void AddUser(List<User> users)
    {
        var user = new User();
        Console.WriteLine("Enter user's ID:");
        user.Id = NumberValidator.Validate(User.minId, User.maxId, "Please, enter valid User ID");
        user.Age = NumberValidator.Validate(User.minAge, User.maxAge, "Please, enter valid User age");
        user.Name = TextValidator.Validate("Please, enter valid User name");
        AddProduct(user);
    }

    public void AddProduct(User user)
    {
        Product product = new Product();
        Console.WriteLine("Add products to the cart");
        product.Category = TextValidator.Validate("Please, enter valid Category name");
        product.Id = NumberValidator.Validate(Product.minId, Product.maxId, "Please, enter valid Product ID");
        product.Name = TextValidator.Validate("Please enter valid Product Name");
        product.Price =
            NumberValidator.Validate(Product.minPrice, Product.maxPrice, "Please, enter valid Product Price");
        user.Cart.products.Add(product);
    }
}