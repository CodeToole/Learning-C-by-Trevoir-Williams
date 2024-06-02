using System;

decimal results = 0;
decimal num1, num2 = 0;
decimal answer = 0;

while (results != -1)
{
    try
    {
        Console.WriteLine("Welcome to Neil's calculator!");
        Console.WriteLine("Please select an option of operation (use -1 to exit):");
        Console.WriteLine("1) Addition");
        Console.WriteLine("2) Subtraction");
        Console.WriteLine("3) Division");
        Console.WriteLine("4) Multiplication");
        Console.WriteLine("5) Fibonacci sequence");

        results = Convert.ToDecimal(Console.ReadLine());

        if (results == -1)
        {
            break;
        }

        Console.WriteLine("Enter your first number:");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter your second number:");
        num2 = Convert.ToDecimal(Console.ReadLine());

        switch (results)
        {
            case 1:
                answer = num1 + num2;
                break;
            case 2:
                answer = num1 - num2;
                break;
            case 3:
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                answer = num1 / num2;
                break;
            case 4:
                answer = num1 * num2;
                break;
            case 5:
                // Ensure the first number is less than the second number
                if (num1 > num2)
                {
                    decimal temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                // Calculate Fibonacci sequence within the range of num1 to num2
                decimal a = 0, b = 1, c = 0;
                Console.WriteLine("Fibonacci sequence: ");
                while (c <= num2)
                {
                    if (c >= num1)
                    {
                        Console.Write($"{c} ");
                    }
                    a = b;
                    b = c;
                    c = a + b;
                }
                Console.WriteLine(); // For a new line after printing the sequence
                break;
            default:
                throw new Exception("Invalid menu item selected");
        }

        // Print output
        Console.WriteLine($"The result is {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
}

Console.WriteLine("Thank you for using Neil's calculator!");
