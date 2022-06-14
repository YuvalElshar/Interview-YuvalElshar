// What is the output of the program below? Explain your answer.

// The program prints 10 10 ... 10, line by line 10 times. The variable i that is added to each action in the list
// is a reference and not value copy. That is why for every call it points to the same memory location and gets the same value. 
// If you init a new value each time(like i did with j in line 18), a new address will be passed to the list,
// and every action will have it's own variable.
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var printers = new List<Action>();
		var i = 0;
		
		for (i = 0; i < 10; i++)
		{
			//int j = i; 
			printers.Add(() => Console.WriteLine(i)); //...WriteLine(j) will print all numbers
		}

		foreach (var printer in printers)
		{
			printer();
		}
	}
}
