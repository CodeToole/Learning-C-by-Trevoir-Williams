// See https://aka.ms/new-console-template for more information

///Welcome message 
///

Console.WriteLine("Welcome to Neil calculator !");


//show Calculator options 

Console.WriteLine("please select an option of operation (use -1 to exit) "  );
Console.WriteLine("1) Addition ");
Console.WriteLine("2)Subtraction ");
Console.WriteLine("3) Division  ");
Console.WriteLine("4) Multiplications ");
Console.WriteLine("5) Fibonacci sequence  ");

//prop for User input
//
decimal Results = Convert.ToDecimal(Console.ReadLine());
while (Results != -1 )
{
    Console.WriteLine("Enter your first number ");
    decimal num1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Enter your Second  number ");
    decimal num2 = Convert.ToDecimal(Console.ReadLine());

    //Decide which operation is needed based on selection options 

    decimal answer = 0;

    switch (Results)
    {
        case 1:
            answer = num1 + num2;
            break;
        case 2: answer = num1 - num2; break;
        case 3: answer = num1 / num2; break;
        case 4: answer = num1 * num2; break;
        case 5:
            for (decimal i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;




        default:
            Console.WriteLine("Invalid choice ");
            break;
    }







    //Print output 
    Console.WriteLine($"The result  is {answer}");

    Console.WriteLine("Press enter to continue");
    Console.ReadLine();

    Console.Clear();

    Console.WriteLine("please select an option of operation (use -1 to exit) ");
    Console.WriteLine("1) Addition ");
    Console.WriteLine("2)Subtraction ");
    Console.WriteLine("3) Division  ");
    Console.WriteLine("4) Multiplications ");
    Console.WriteLine("5) Fibonacci sequence  ");
    Results = Convert.ToDecimal(Console.ReadLine());


}
Console.WriteLine("think you for Using Neil calculator !");

