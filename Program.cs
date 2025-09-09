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

//Do some math
int distance;
int ConvertedMPH;
int.TryParse(miles, out distance);
int.TryParse(MPH, out ConvertedMPH);
int time = distance / ConvertedMPH;
TimeSpan.FromMinutes(time).ToString(@"hh\:mm");


Console.Clear();

Console.WriteLine("Here is your trip summary:");

Console.WriteLine($"Driver: {driver,20}");
Console.WriteLine($"Currency: {currency,20}");
Console.WriteLine("");
Console.WriteLine($"Miles: {miles,20}");
Console.WriteLine($"Average speed (MPH): {MPH,20}");
Console.WriteLine($"Average time driving, {time, 20} ");