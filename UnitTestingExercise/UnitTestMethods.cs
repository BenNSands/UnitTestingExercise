using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // DONE Make sure your references are set properly
        // DONE Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
            //throw new NotImplementedException();
        }
        // Create a Subtract method that passes 2 integers
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
            //throw new NotImplementedException();
        }
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
            //throw new NotImplementedException();
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
           // throw new NotImplementedException();
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string HelloWorld()
        {
            return "Hello World!";
            //throw new NotImplementedException();
        }
        public int OnePlusOne()
        {
            return 1 + 1;
            //throw new NotImplementedException();
        }
    }
}
