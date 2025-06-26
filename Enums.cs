// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public enum Month
    {
        January=1,February,March,April,May,June,July,August,September,October,November,December
    }
    public static void Main(string[] args)
    {
        //Month now = Month.July;
    //     Month now =(Month)12;
    // Console.WriteLine(now);
    //  int value =(int) Month.June;
    //  Console.WriteLine(value);
    // Console.WriteLine("Enter Your Month:January=1,February=2,March=3");
    // int value =int.Parse(Console.ReadLine());
    // Month user=(Month)value;
    // Console.WriteLine(user);
    // string[] members=(string[])Enum.GetNames(typeof(Month));
    // foreach(string member in members)
    // {Console.WriteLine(member);}
    // int[] members=(int[])Enum.GetValues(typeof(Month));
    // foreach(int member in members)
    // {
    // Console.WriteLine(member);
        
    // }
//   Month my=Month.July;
int my =(int)Month.July;
    switch   (my)                           
    {           
        case 1:
        Console.WriteLine("Hello This is January");
        break;
        case 2:
        Console.WriteLine("Hello This is February");
         break;   
        case 3:
        Console.WriteLine("Hello This is January");
        break;
        case 4:
        Console.WriteLine("Hello This is April");
        break;
        case 5:
        Console.WriteLine("Hello This is May");
        break;
        case 6:
        Console.WriteLine("Hello This is JUNE");
        break;
        case 7:
        Console.WriteLine("Hello This is July");
        break;
        case 8:
        Console.WriteLine("Hello This is August");
        break;
        case 9:
        Console.WriteLine("Hello This is September");
        break;
        case 10:
        Console.WriteLine("Hello This is October");
        break;
        case 11:
        Console.WriteLine("Hello This is November");
        break;
        case 12:
        Console.WriteLine("Hello This is December");
        break;
        default:
        Console.WriteLine("Invalid Month..");
        break;

    }
    // switch   (my)                           
    // {           
    //     case Month.January:
    //     Console.WriteLine("Hello This is January");
    //     break;
    //     case Month.February:
    //     Console.WriteLine("Hello This is February");
    //      break;   
    //     case Month.March:
    //     Console.WriteLine("Hello This is January");
    //     break;
    //     case Month.April:
    //     Console.WriteLine("Hello This is April");
    //     break;
    //     case Month.May:
    //     Console.WriteLine("Hello This is May");
    //     break;
    //     case Month.June:
    //     Console.WriteLine("Hello This is JUNE");
    //     break;
    //     case Month.July:
    //     Console.WriteLine("Hello This is July");
    //     break;
    //     case Month.August:
    //     Console.WriteLine("Hello This is August");
    //     break;
    //     case Month.September:
    //     Console.WriteLine("Hello This is September");
    //     break;
    //     case Month.October:
    //     Console.WriteLine("Hello This is October");
    //     break;
    //     case Month.November:
    //     Console.WriteLine("Hello This is November");
    //     break;
    //     case Month.December:
    //     Console.WriteLine("Hello This is December");
    //     break;
    //     default:
    //     Console.WriteLine("Invalid Month..");
    //     break;

    // }
    }
}