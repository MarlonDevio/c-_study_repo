string message = "Hello World";
Console.WriteLine(message.ToUpper());

// Empty string 
string emptyMessage = string.Empty;
string stringWithDoubleQuotes = "This is a string with double quotes \" ";
Console.WriteLine(stringWithDoubleQuotes);

// 2 slashes
string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C\temp";

// string length
Console.WriteLine(filePath.Length);

Console.WriteLine(filePath + filePath);

// string interpolation
string firstName = "marlon";
string lastName = "hamaekers";
string fullName = $"{firstName} {lastName}";
Console.WriteLine(fullName);

for (int i = 0; i < fullName.Length; i++)
{
    Console.WriteLine(fullName[i]);
}
 