// See https://aka.ms/new-console-template for more information

using Drivers;

var drivers = DriversFactory.GenerateDrivers(3);
ChatBot.ShowAllDrivers(drivers);
ChatBot.SelectDriver();
ChatBot.ShowInfo(drivers);
Console.WriteLine(11 / 100);
