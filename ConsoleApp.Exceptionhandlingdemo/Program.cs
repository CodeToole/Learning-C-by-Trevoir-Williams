// See https://aka.ms/new-console-template for more information


// Write a program that takes a user's age as input and printed on the screen 
//Display an error message if an invalid input is received 
try
{
    Console.WriteLine("What is your age ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old ");

}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect please try again ");
    //throw;
}
finally {
    Console.WriteLine( "Thank you for using this app ");

}






