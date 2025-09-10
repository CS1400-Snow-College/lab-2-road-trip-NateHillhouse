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


Console.Clear();
Console.WriteLine(time);
Console.WriteLine(distance);
Console.WriteLine(ConvertedMPH);
double length = driver.Length;
Console.WriteLine("Here is your trip summary:");
const int space = 30;
Riders += 1; //For the driver
//The number after "space" is the character count of the phrase before

Console.WriteLine($@"Driver: {driver, space - 8}
Currency: {currency,space-10}

Miles: {miles,space-7}
Average speed (MPH): {MPH,space-21}
Time driving: {time,space - 14:f0} Minutes

Miles per Gallon: {ConvertedMPG, space - 18}
Fuel Needed: {fuelneeded, space:f2} Gallons
Range Per tank: {tankRange, space:f2} Miles
Estimated Fuel Stops: {distance/tankRange, space:f0f}

Fuel Cost: {currency}{fuelcost, space:f2}
Riders: {Riders, space}
Cost per Person: {currency}{Riders, space:f2}
Cost per Mile: {currency}{convertedPrice/distance, space:f2}
Cost per driving hour: {currency}{fuelcost/time, space:f2}

Average song length: 3.5 min
Songs needed: {time/3.5:f0}
");
