// See https://aka.ms/new-console-template for more information
using System.Net;

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
//Converting the following to double for compatibility
double.TryParse(miles, out double distance);
double.TryParse(MPH, out double ConvertedMPH);
double.TryParse(MPG, out double ConvertedMPG);
double.TryParse(gallons, out double convertedGallons);
double tankRange = ConvertedMPG * convertedGallons;
double.TryParse(passengers, out double Riders);
double.TryParse(price, out double convertedPrice);

double fuelneeded = distance / ConvertedMPG;
double fuelcost = convertedPrice * fuelneeded;
double time = distance / ((double) ConvertedMPH/60); //Converting hours to minutes
//TimeSpan.FromMinutes(time).ToString(@"hh\:mm");
string formattedTime = (time / 60) + "h " + (time % 60) + "m";

Console.Clear();
double length = driver.Length;
Console.WriteLine("Here is your trip summary:");
const int space = -30;
Riders += 1; //For the driver
//The number after "space" is the character count of the phrase before

Console.WriteLine($@"{"Driver:", space} {driver}
{"Currency: ", space}{currency}

{"Miles: ", space}{miles}
{"Average speed (MPH): ", space}{MPH}
{"Time driving: ", space}{formattedTime:f0}

{"Miles per Gallon: ", space}{ConvertedMPG}
{"Fuel Needed: ", space}{fuelneeded:f2} Gallons
{"Range Per tank: ", space}{tankRange:f0} Miles
{"Estimated Fuel Stops: ", space}{distance/tankRange:f0}

{"Fuel Cost: ", space}{currency}{fuelcost:f2}
{"Riders: ", space}{Riders, space-7}
{"Cost per Person: ", space}{currency}{Riders/fuelcost:f2}
{"Cost per Mile: ", space}{currency}{fuelcost/distance:f2}
{"Cost per driving hour: ", space}{currency}{fuelcost/time:f2}

{"Average song length: ", space}{3.5} min
{"Songs needed: ", space}{time/3.5:f0}
");
