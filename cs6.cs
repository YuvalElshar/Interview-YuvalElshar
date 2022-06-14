// What is the output of the short program below? Explain your answer.

//output:
//Exception 1
//ApplicationException 2
//Finally

// The first try is running and throw general Exeption with message attach, the first catch, catch that Exeption and
// print the message of the Exeption.
// The second try is running and throw ApplicationException. for that try there are 2 catch. one is 
// to handle ApplicationException and the other is for Exeption. the ApplicationException handling is execute 
// and print "ApplicationException 2"
// "finally" is always execute,  and print "Finally"


using System;

public class Program
{
	public static void Main()
	{
		try
		{
			throw new Exception("Exception 1");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		try
		{
			throw new ApplicationException("Exception 2");
		}
		catch (ApplicationException)
		{
			Console.WriteLine("ApplicationException 2");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("Finally");
		}
	}
}