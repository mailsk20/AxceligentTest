using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1 - Answer - [Sum of Biggest Neighbor]
            Console.WriteLine("\n\n********** QUESTION 1 [Sum of Biggest Neighbor] *********\n\n");
            var question1 = new Question1();
            var result1 = question1.Challenge(new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 });
            var result2 = question1.Challenge(new int[] { 1, 6, 1, 2, 6, 1, 6, 6 });
            var result3 = question1.Challenge(new int[] { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 });


            //Question2 - Answer - [Sum of Biggest Neighbor]
            Console.WriteLine("\n\n********** QUESTION 2 [User Class] *********\n\n");
            var question2 = new Question2();
            question2.UserClass();


            //Question3 - Answer - [John the Robot]
            Console.WriteLine("\n\n********** QUESTION 3 [John the Robot] *********\n\n");
            var question3 = new Question3();
            question3.JohnRobot();


            //Question4 - Answer - [Alexa Settings]
            Console.WriteLine("\n\n********** QUESTION 4 [Alexa Settings] *********\n\n");
            var question4 = new Question4();
            question4.AlexaSettings();

            //Question5 - Answer - [Method Signature]
            Console.WriteLine("\n\n********** QUESTION 5 [Method Signature] *********\n\n");
            Console.WriteLine("For method signature please refer the Question5.cs file.");
            /*

            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);

            Above method signature please refer the Question5.cs file.

            */


            //Question6 - Answer - [Construction Game]
            Console.WriteLine("\n\n********** QUESTION 6 [Construction Game] *********\n\n");
            var question6 = new Question6();
            question6.ConstructionGame();

            //Question7 - Answer - [ES6 Import]
            Console.WriteLine("\n\n********** QUESTION 7 [ES6 Import] *********\n\n");
            Console.WriteLine("Answer: \n");

            Console.WriteLine("type 1: import {Car} from 'app.js';");
            Console.WriteLine("answer1: ");
            Console.WriteLine("answer5: ");

            Console.WriteLine("\n\ntype 2: import Car from 'app.js';");
            Console.WriteLine("answer2: ");
            Console.WriteLine("answer4: ");


            //Question7 - Answer - [Typescript Mastery]
            Console.WriteLine("\n\n********** QUESTION 8 [Typescript Mastery] *********\n\n");
            Console.WriteLine("For implement the @subtract and @multiply in typescript, please refer the Question8.ts file.");


            Console.WriteLine("\n\n********** End Test *********\n\n");
            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}
