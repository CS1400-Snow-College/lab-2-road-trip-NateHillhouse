// See https://aka.ms/new-console-template for more information
Console.WriteLine("We are going to go on a road trip. I will ask you some questions to help create a trip summary for you!");

//Get the destination
Console.Write("Where will you be driving? ");
string destination = Console.ReadLine();
//Driver
Console.Write("Who will be driving? ");
string driver = Console.ReadLine();
//Miles to destination
Console.Write("How many miles is there to your destination? ");
string miles = Console.ReadLine();
//Average MPH
Console.Write($"What average speed with {driver} be driving? ");
string MPH = Console.ReadLine();
//MPG
Console.Write("How many MPG does your car get? ");
string MPG = Console.ReadLine();
//Gallons that the car holds
Console.Write("How many gallons does your car hold? ");
string gallons = Console.ReadLine();
//Number of passengers
Console.Write("How many passengers will be riding, excluding the driver? ");
string passengers = Console.ReadLine();
//Unit of currency
Console.Write("What unit of currency ($, £, ¥, €) will you be using? ");
string currency = Console.ReadLine();
//Fuel price per gallon
Console.Write("What is the fuel price per gallon?");
string price = Console.ReadLine();
