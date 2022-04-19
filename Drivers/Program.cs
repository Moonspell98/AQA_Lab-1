// See https://aka.ms/new-console-template for more information

using Drivers;

var drivers = DriversFactory.GenerateDrivers(3);
var chatBot = new ChatBot(drivers);
chatBot.ShowAllDrivers();
chatBot.SelectDriver();
chatBot.ShowCars();
chatBot.SelectCar();
chatBot.CalculateVehicleAbilities();
