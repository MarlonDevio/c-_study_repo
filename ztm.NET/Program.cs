// Bool

using System.Runtime.Intrinsics.X86;bool enabled = true;


Console.WriteLine($"{enabled}");

// char
char c1 = 'a';

Console.WriteLine($"{c1}");

// ints

int one = 1;
int two = 2;
int negativeOne = -1;
int negativeSeven = -7;

// arithmetic ops
int multiply = one * two;
int divide = two / negativeOne;
int divideNegative = negativeSeven / two;

Console.WriteLine($"Dividing: {negativeSeven} / {two} = {divideNegative}");
Console.WriteLine($"{one / two }");

// Copying values 
int a1 = 7;
int a2 = a1;
a1 = 5;

Console.WriteLine($"{a1}, {a2},{a1}");

