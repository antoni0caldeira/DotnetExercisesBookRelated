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
/// This function performs a loop until the user inserts a valid number.
/// </summary>
/// <param name="promptMessage">A string that is displayed as a prompt to the user for input.</param>
/// <returns>An integer that the user has entered.</returns>
/// <remarks>
/// The function handles null inputs, format exceptions, and overflow exceptions.
/// If the input is null, the function displays a message and continues with the next iteration of the loop.
/// If the input is not a valid integer format, the function catches a FormatException and asks the user to insert a valid number.
/// If the input is too large or too small for an Int32, the function catches an OverflowException and asks the user to insert a valid number.
/// </remarks>
int ValidateNumber(string promptMessage)
{
    // Variable declaration
    // number: An integer to store the valid number input from the user
    int number;

    // Perform a loop until the user inserts a valid number
    while (true)
    {
        try
        {
            // Display the prompt message to the user
            Console.WriteLine(promptMessage);

            // Read the user's input
            string input = Console.ReadLine();

            // If the input is null, display an error message and continue with the next iteration of the loop
            if (input == null)
            {
                Console.WriteLine("Input stream ended unexpectedly. Please try again.");
                continue;
            }

            // Try to convert the input to an integer
            number = Convert.ToInt32(input);

            // If the input is a valid integer, exit the loop
            break;
        }
        // If the input is not a valid integer format, catch the exception and ask the user to insert a valid number
        catch (FormatException)
        {
            Console.WriteLine("Invalid format. Please insert a valid number.");
        }
        // If the input is too large or too small for an Int32, catch the exception and ask the user to insert a valid number
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small for an Int32.");
        }
    }

    // Return the valid number input from the user
    return number;
}

// Getting input from user
firstNumber = ValidateNumber("Please insert the first number");
secondNumber = ValidateNumber("Please insert the second number");

// Performing the operations
result = SummingTwoNumbers(firstNumber, secondNumber);

// Printing the result
Console.WriteLine($"The sum is equal to {result}");
