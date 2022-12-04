//3.	Write a program with ref and out keywords
/*
The ref is a keyword in C# which is used for the passing the 
arguments by a reference. Or we can say that if any changes made 
in this argument in the method will reflect in that variable 
when the control return to the calling method.

The out is a keyword in C# which is used for the passing 
the arguments to methods as a reference type. It is generally 
used when a method returns multiple values. The out parameter 
does not pass the property.
*/

namespace ref_out_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref
            // Assign string value
            string str = "Sanju";

            // Pass as a reference parameter
            SetValue(ref str);

            // Display the given string
            Console.WriteLine(str);

            //out

            // Declaring variable
            // without assigning value
            int num;

            // Pass variable G to the method
            // using out keyword
            Sum(out num);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", num);
        }

        //ref
        static void SetValue(ref string str1)
        {

            // Check parameter value
            if (str1 == "Sanju")
            {
                Console.WriteLine("Welcome Sanjana");
            }

            // Assign the new value
            // of the parameter
            str1 = "Krishna";
        }

        //out
        public static void Sum(out int number)
        {
            number = 80;
            number += number;
            //number *= number;
        }
    }
}