Console.WriteLine("Enter two number, from space (50 10):");
var input = Console.ReadLine().Split(' ');

if (input.Length == 2 && double.TryParse(input[0], out var value) && double.TryParse(input[1], out var percent))
    Console.WriteLine($"Total: {value*percent/100}");
else
    Console.WriteLine("Error.");