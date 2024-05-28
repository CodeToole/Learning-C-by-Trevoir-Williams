//ConsoleApp.ConditionsAndDecisions

// promt for input
using System.ComponentModel.Design;

Console.WriteLine("enter a student's grade ");
int grade = Convert.ToInt32(Console.ReadLine());

//Decisions on past I feel based on input
//
Console.WriteLine("*********simple If Results*****");


if (grade > 50)
{
    Console.WriteLine("Student has passed ");
}
else
{
    Console.WriteLine("Student has fail  ");
    Console.WriteLine("Please recommend students to students affair office ");
}

Console.WriteLine( "********* Simple results ends *******");





Console.WriteLine("********Complex if else results begins ");

// Complex if... Else if ....Decide to print letters based on grade values 


/*
 * A: 85-100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 -64 else if(grade>= 50 && <==64)
 * F: Less than 50
 */


if (grade <0 || grade > 100)
{
    Console.WriteLine("Invalid value entered ");
}
else if (grade < 50)
{

    Console.WriteLine("Student has Failed  - F");
}
else if (grade >= 50 &&  grade <= 64)
{
    Console.WriteLine("C-");

}

else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");

}
else if (grade >= 75  && grade <= 84)
{
    Console.WriteLine("B");

}

else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A");

}
int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : 0;
Console.WriteLine($"Grade after bonus {gradeAfterBonus} ");




Console.WriteLine("********Complex if else results End ");

//Ternary operator - used to assight a value to a variable base on a condition.


Console.WriteLine("**********Ternary operator result*******");
string passStatus = grade < 50 ? "Fail " : "Pass";
Console.WriteLine($"Student status is : {passStatus}");


//Switch statements operations - Use to Evaluate a value and take in action 
Console.WriteLine("********* Switch statements result ***********");
/*
 Write a program to accept an integer as the day of the week and print appropriate message as outlined below 
1- Sunday 
2-Monday 
3-Tuesday 
4-Wednesday (Hump Day)
5-thursday
6-friday (TGIF!!!)
7-saturday(sabbath day )
*/
Console.WriteLine("Please enter the day of the week ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        //morecode
        //morecode
        break;
        
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday ");
        break;
    case 4:
        Console.WriteLine("Wednesday hump day ");
        break;
    case 5:
        Console.WriteLine("Thursday ");
        break;
    case 6:
        Console.WriteLine("Friday TGIF ");
        break;
    case 7:
        Console.WriteLine("Saturday ");
        break;
    default:
        Console.WriteLine("Invalid day number enter ");
        break;


}
Console.WriteLine("********* Switch statements result End ***********");

Console.WriteLine("Thank you for using this program ");