// Variables declaration
int firstNumber = 0;
int secondNumber = 0;
int result = 0;

// Method declaration
int SummingTwoNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

/// <summary>
/// Performs a loop until the user inserts a valid number
/// </summary>
int ValidateNumber(string promptMessage)
{
    int number;
    while (true)
    {
        try
        {
            Console.WriteLine(promptMessage);
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input stream ended unexpectedly. Please try again.");
                continue;
            }
            number = Convert.ToInt32(input);
            break; // exit the loop if the input is valid
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format. Please insert a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small for an Int32.");
        }
    }
    return number;
}

// Getting input from user
firstNumber = ValidateNumber("Please insert the first number");
secondNumber = ValidateNumber("Please insert the second number");

// Performing the operations
result = SummingTwoNumbers(firstNumber, secondNumber);

// Printing the result
Console.WriteLine($"The sum is equal to {result}");
