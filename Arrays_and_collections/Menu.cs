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
        while (choice != 3)
        {
            Console.WriteLine("1. Show all users");
            Console.WriteLine("2. Add user");
            Console.WriteLine("3. Exit");
            choice = NumberValidator.Validate(1, 3, "Please, select option");
            if (choice == 1)
            {
                ShowAllUsers(_users);
                int userIndex = NumberValidator.Validate(1, _users.Count, "Please, select user") - 1;
                ShowUserCart(_users[userIndex]);
                int productActionFlag = NumberValidator.Validate(0, 2,
                    "To add Products to the User's card enter 1, to remove products enter 2, to stop adding "
                        + "Products enter 0");
                while (productActionFlag != 0)
                {
                    switch (productActionFlag)
                    {
                        case 1:
                            AddProduct(_users[userIndex].Cart);
                            if (_users[userIndex].Age < User.ageOfMajority &&
                                _users[userIndex].Cart.products[_users[userIndex].Cart.products.Count - 1].Category ==
                                "Alcohol")
                            {
                                _users[userIndex].Cart.products.RemoveAt(_users[userIndex].Cart.products.Count - 1);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("A minor cannot buy alcohol!");
                                Console.ResetColor();
                            }

                            ShowUserCart(_users[userIndex]);
                            productActionFlag = NumberValidator.Validate(0, 2,
                                "To add Products to the User's card enter 1, to remove products enter 2, to stop "
                                + "adding Products enter 0");
                            break;
                        case 2:
                            int productIndexToRemove = NumberValidator.Validate(1,
                                _users[userIndex].Cart.products.Count,
                                "Select product to remove");
                            _users[userIndex].Cart.products.RemoveAt(productIndexToRemove - 1);
                            productActionFlag = NumberValidator.Validate(0, 2,
                                "To add Products to the User's card enter 1, to remove products enter 2, to stop "
                                    + "adding Products enter 0");
                            break;
                    }
                }
            }
            else if (choice == 2)
            {
                int AddUserFlag = 1;
                while (AddUserFlag == 1)
                {
                    AddUser(_users);
                    AddUserFlag = NumberValidator.Validate(0, 1,
                        "To add new User enter 1, to stop adding Users enter 0");
                }
            }
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

    public void ShowUserCart(User user)
    {
        Console.WriteLine(user.Name + "'s cart contains");
        Console.WriteLine("| {0,17} | {1, 11} | {2, 25} | {3, 8} |", "Product Category", "Product Id", "Product Name",
            "Price");
        foreach (var product in user.Cart.products)
        {
            Console.WriteLine("| {0,17} | {1, 11} | {2, 25} | {3, 8} |", product.Category, product.Id, product.Name,
                product.Price);
        }
    }

    public void AddUser(List<User> users)
    {
        var user = new User();
        bool isIdUnique = false;
        while (!isIdUnique)
        {
            user.Id = NumberValidator.Validate(User.minId, User.maxId, "Please, enter valid User ID");
            bool hasDuplicate = users.Any(s => s.Equals(user));
            if (hasDuplicate)
            {
                Console.WriteLine("You entered duplicate id");
            }
            else
            {
                isIdUnique = true;
            }
        }

        user.Age = NumberValidator.Validate(User.minAge, User.maxAge, "Please, enter valid User age");
        user.Name = TextValidator.Validate("Please, enter valid User name");
        user.Cart = new Cart();
        int addProductFlag = 1;
        while (addProductFlag == 1)
        {
            AddProduct(user.Cart);
            if (user.Age < User.ageOfMajority && user.Cart.products[user.Cart.products.Count - 1].Category == "Alcohol")
            {
                user.Cart.products.RemoveAt(user.Cart.products.Count - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A minor cannot buy alcohol!");
                Console.ResetColor();
            }

            addProductFlag =
                NumberValidator.Validate(0, 1,
                    "To add new product enter 1, to stop adding products enter 0");
        }

        users.Add(user);
    }

    public void AddProduct(Cart cart)
    {
        Product product = new Product();
        Console.WriteLine("Add products to the cart");
        product.Category = TextValidator.Validate("Please, enter valid Category name");
        product.Id = NumberValidator.Validate(Product.minId, Product.maxId, "Please, enter valid Product ID");
        product.Name = TextValidator.Validate("Please enter valid Product Name");
        product.Price =
            NumberValidator.Validate(Product.minPrice, Product.maxPrice, "Please, enter valid Product Price");
        cart.products.Add(product);
    }
}