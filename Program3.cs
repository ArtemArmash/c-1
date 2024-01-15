int number = 0;

for (int i = 0; i < 4; i++)
if (int.TryParse(Console.ReadLine(), out int digit)) number = number * 10 + digit;
else Console.WriteLine("Error.");

Console.WriteLine($"New number: {number}");
