
// Enumaerations


using System;
namespace EnumeratedConstants
{
 class EnumeratedConstants
 {
 enum Temperatures
 {
 WickedCold = 0,
 FreezingPoint = 32,
 LightJacketWeather = 60,
 SwimmingWeather = 72,
 BoilingPoint = 212,
 }
 static void Main(string[] args)
 {
 System.Console.WriteLine("Freezing point of water: {0}",
 (int)Temperatures.FreezingPoint);
 System.Console.WriteLine("Boiling point of water: {0}",
 (int)Temperatures.BoilingPoint);
 }
 }
}
