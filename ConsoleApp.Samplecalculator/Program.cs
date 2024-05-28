// See https://aka.ms/new-console-template for more information

///Welcome message 
///

Console.WriteLine("Welcome to Neil calculator !");

//prop for User input 
Console.WriteLine("Enter your first number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second  number ");
int num2 = Convert.ToInt32(Console.ReadLine());

//show Calculator options 

Console.WriteLine("please select an option of operation "  );
Console.WriteLine("1) Addition ");
Console.WriteLine("2)Subtraction ");
Console.WriteLine("3) Division  ");
Console.WriteLine("4) Multiplications ");


//Decide which operation is needed based on selection options 
int Results = Convert.ToInt32(Console.ReadLine());
int answer = 0;

switch (Results)
{
    case 1:
        answer = num1 + num2;
        break;
    case 2: answer = num1 - num2; break;
    case 3: answer = num1 / num2; break;
    case 4: answer = num1 * num2; break;





    default:
        Console.WriteLine("Invalid choice ");
        break;
}







//Print output 
Console.WriteLine($"The result  is {answer}");

