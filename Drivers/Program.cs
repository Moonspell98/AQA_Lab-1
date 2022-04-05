// See https://aka.ms/new-console-template for more information

using Drivers;

var drivers = DriversFactory.GenerateDrivers(3);
ChatBot.ShowAllDrivers(drivers);

