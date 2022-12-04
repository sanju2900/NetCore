using System;

//1.	Create a program to explain overriding concept.
namespace Method_Overriding
{
    class Father
    {
        // here we used virtual and overriding
        //if we don't use it then it will only print Parent class Father not derived class
        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Parent class Father");
        }
    }


    // class 'Father' inherit
    // class 'Son-drived method'
    //: this mean inheriting
    class Son : Father
    {

        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Son is here derived class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // 'obj' is the object
            // of class 'Father'
            Father obj = new Father();

            // it invokes 'show()'
            // of class 'Father'
            obj.show();


            // the same object 'obj' is now
            // the object of class 'Son'
            obj = new Son();

            // it invokes 'show()' of class 'Son'
            // 'show()' of class 'Son' is overridden
            // for 'override' modifier
            obj.show();
        }
    }
}








