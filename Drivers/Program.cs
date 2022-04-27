using Drivers;

var drivers = DataGenerator.CreateDrivers(3);
var chatBot = new ChatBot(drivers);
chatBot.ShowAllDrivers();
chatBot.SelectDriver();
chatBot.ShowCars();
chatBot.SelectCar();
chatBot.CalculateVehicleAbilities();
