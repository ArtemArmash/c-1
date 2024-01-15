Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 100)
{
    if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("Fizz Buzz");
    else if (number % 3 == 0) Console.WriteLine("Fizz");
    else if (number % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(number);
}
else  Console.WriteLine($"Your number {number} is not in the range of 1 to 100.");