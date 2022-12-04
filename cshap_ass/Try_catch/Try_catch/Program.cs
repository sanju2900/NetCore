//2.	What is try and catch blocks in c#.
/*The main purpose of the catch block is to handle the exception raised
in the try block. This block is only going to execute when the 
exception raised in the program.In C#, You can use more than one 
catch block with the try block. Generally, multiple catch block is 
used to handle different types of exceptions means each catch block
is used to handle different type of exception. If you use multiple 
catch blocks for the same type of exception, then it will give you 
a compile-time error because C# does not allow you to use multiple 
catch block for the same type of exception
*/
namespace Try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // This block raises an exception
        try {
                Console.WriteLine("Enter your data:");
                //int data = Convert.ToInt32(Console.ReadLine()); ;
            byte data = byte.Parse(Console.ReadLine());
            Console.WriteLine(data);
        }
  
        // Catch block 1
  
        // This block is used to handle
        // IndexOutOfRangeException type exception
        catch (IndexOutOfRangeException) {
  
            Console.WriteLine("At least provide one Argument!");
        }
  
        // Catch block 2
  
        // This block is used to handle
        // FormatException type exception
        catch (FormatException) {
  
            Console.WriteLine("Entered value in not a number!");
        }
  
        // Catch block 3
  
        // This block is used to handle
        // OverflowException type exception
        catch (OverflowException) {
  
            Console.WriteLine("Data is out of Range!");
        }
  
        }
    }
}