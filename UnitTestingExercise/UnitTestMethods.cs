﻿using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Right-click on Dependencies in your .Tests project and set your reference



        //DONE Create an Add method that passes 3 integers
        public int Add(int one, int two, int three, int expected)
        {
            return one + two + three;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        //DONE Create a Subtract method that passes 2 integers
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        //DONE Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote


    }
}
