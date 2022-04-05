// See https://aka.ms/new-console-template for more information

using Drivers;

var driver = DriverGenerator.CreateDriver();
Console.WriteLine(driver.Name + " " + driver.DateOfBirth + " " + driver.DateOfGetLicense);

