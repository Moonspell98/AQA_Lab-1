// See https://aka.ms/new-console-template for more information

using Arrays_and_collections;

var users = UsersFactory.CreateUsers(5);

Menu menu = new Menu(users);
menu.ShowMenu();