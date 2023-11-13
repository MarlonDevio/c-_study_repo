// Implicit conversions: No special syntax, no data loss, no precision loss
// Explicit conversions: Castings, potential data loss, potential precision loss

using System.Threading.Channels;

int age = 31;
// 'f' Shows floating point number
float weight = 78.7f;

Console.WriteLine($"age: {age}, weight: {weight}");

// implicit conversions
long myAge = age;
Console.WriteLine($"{myAge}");

// explicit conversions
int lessWeight = (int)weight; // precision loss
int notMyAge = (int)myAge; // No precision loss

long bigNumber = 1111111111111111111;
int smallerType = (int)bigNumber;

Console.WriteLine($"{ bigNumber }, { smallerType}");
