using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////EX6 --AGE IN MONTHS CALCULATE AGE IN MONTHS BASED ON YEARS
            ////Declaration
            //int ageYears, ageMonths;

            ////ask for user input
            //Console.WriteLine("Input your age in years");
            //ageYears = Convert.ToInt32(Console.ReadLine());

            ////process
            //ageMonths = ageYears * 12;

            ////display for user
            //Console.WriteLine("Your age in months is:" + ageMonths);



            ////EX7 -- SIMPLE INTEREST CALCULATOR
            ////Declaration
            //double principal, rate, years, totalInterest;

            ////input
            //Console.WriteLine("What is the principal amount of the loan in dollars?");
            //principal = Convert.ToDouble(Console.ReadLine());

            ////input
            //Console.WriteLine("What is the interest rate (input 0.05 for 5%");
            //rate = Convert.ToDouble(Console.ReadLine());

            ////input
            //Console.WriteLine("What is the period of the loan in years?");
            //years = Convert.ToDouble(Console.ReadLine());

            ////process
            //totalInterest = principal * rate * years;

            ////output
            //Console.WriteLine("Total interest of loan: " + totalInterest..ToString("#.##));



            ////EX8 -- WRITE A PROGRAM THAT GREETS THE USER BY NAME

            ////Declartion
            //string name;

            ////Input
            //Console.WriteLine("Input your name:");
            //name = Console.ReadLine();

            ////Output
            //Console.WriteLine("Hello, " + name + "!");



            ////EX9 -- SUM OF TWO NUMBERS

            ////DECLARATION
            //double firstNumber, secondNumber, sum;

            ////INPUT
            //Console.WriteLine("Input the first number:");
            //firstNumber = Convert.ToDouble(Console.ReadLine());

            ////INPUT
            //Console.WriteLine("Input the second number:");
            //secondNumber = Convert.ToDouble(Console.ReadLine());

            ////process
            //sum= firstNumber + secondNumber;

            ////output
            //Console.WriteLine("The sum of the two numbers is: " + sum);


            //EX10 -- SIMPLE PASSWORD CHECKER

            ////DECLARATION
            //string Userpassword;
            //const string password = "secret";

            ////INPUT
            //Console.WriteLine("Enter your password:");
            //Userpassword = Console.ReadLine();

            ////process
            //if (Userpassword == password)

            //{
            //    Console.WriteLine("Successful");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Try again."); 
            //}

            //int age;

            //Console.WriteLine("what is your age");
            //age = Convert.ToInt32(Console.ReadLine());
            //bool CanDrinkAlcohol = false;
            //if (age > 21) 
            //    CanDrinkAlcohol |= true;
            //Console.WriteLine(CanDrinkAlcohol);



            ////EX1 -- Number Classification if its postive, negative or zero, & even or odd

            ////delcaration
            //int userInput;

            ////input
            //Console.WriteLine("Input a number:");
            //userInput = Convert.ToInt32(Console.ReadLine());

            ////process
            //if (userInput == 0)
            //{
            //    Console.WriteLine("Your number is zero");
            //}
            //else if (userInput < 0)

            //{
            //    Console.WriteLine("Your number is negative");
            //}
            //else

            //{
            //    Console.WriteLine("Your number is postive");
            //}
            //if (userInput % 2 == 0)
            //{
            //    Console.WriteLine("It is an even number");

            //}
            //else
            //{
            //    Console.WriteLine("It is an odd number");
            //}


            //EX2 GRADE CONVERTER TAKE NUMERIC SCORE TO LETTER GRADE

            //declaration
            int numericGrade;
            int convertGrade;
            //input
            Console.WriteLine("Enter your numeric grade:");
            numericGrade = Convert.ToInt32(Console.ReadLine());

            //process
            convertGrade = numericGrade / 10;
            
            switch (convertGrade)
            {
                case 0:
                case 1:
                  
                        break;
                case 2:
                    Console.WriteLine("A");
                    break;

                case 3:
                    Console.WriteLine("B");
                    break;

                case 4:
                    Console.WriteLine("C");
                    break;

                case 5:  
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;

                   
            }




        }
    }
}
