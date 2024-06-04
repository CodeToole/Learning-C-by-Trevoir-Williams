// See https://aka.ms/new-console-template for more information
Console.WriteLine("hit any number or to exit hit -1");
int  neil = Convert.ToInt32(Console.ReadLine());

while (neil != -1)
{
    // WriteLine is a method that takes a block of text and print it to the screen.
    Console.WriteLine("Hello, World! My name is Cornelius Toole");
    Console.WriteLine("I am from Jamaica!");
    Console.WriteLine("Anything you want to say");

    // Write is a method that takes a block of text and print it to the screen. 
    // It does not break the line after it prints the text. 
    Console.Write("Line 1");
    Console.Write("Line 2");
    Console.WriteLine();
    Console.WriteLine("hit any number or to exit hit -1");
    neil = Convert.ToInt32(Console.ReadLine());
}
