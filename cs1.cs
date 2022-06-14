// What is the output of the short program below? Explain your answer.
using System;
public class Q1
{
    static string location = default(string);
    static DateTime time = default(DateTime);

    public static void Main()
    {
        Console.WriteLine(location == null ? "location is null" : location);
        Console.WriteLine(time == DateTime.MinValue ? time.ToString() : time.ToString());
    }
}

//The output is :
//location is null
//time is MinValue

//The default val of string is null. string is a reference type, for referemce types the default is null.
//DateTime is a value type, and value types can never be null. Only reference types can be null.
//The default val for DateTime is 01/01/0001 00:00:00 , its minimum value.

