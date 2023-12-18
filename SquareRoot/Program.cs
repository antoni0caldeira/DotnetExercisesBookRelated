Console.WriteLine("Please insert a positive number");
string userInput = Console.ReadLine();

int validatedNumber = ValidateInput(userInput);
if (validatedNumber == -1)
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
    return;
}

double result = CalculateSquareRoot(validatedNumber);
Console.WriteLine($"The square root of {validatedNumber} is {result}");
    

    static int ValidateInput(string input)
{
    if (int.TryParse(input, out int parsedInt) && parsedInt >= 0)
    {
        return parsedInt;
    }
    return -1;
}

static double CalculateSquareRoot(int number)
{
    return Math.Sqrt(number);
}
