using System;
using System.ComponentModel;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var amountOfItems = SumOfTwoNumbers(4, 5);
            var amountOfCoins = ProductOfTwoNumbers(9, 3);
            //-----------------Exercise 1
            //Name: Jon
            //Favorite Color: Black
            //Favorite Animal: Dolphin
            //Favorite Band: Mint Condition

            Console.WriteLine("Enter a name for your character");
            string nameForStory1 = Console.ReadLine();
            Console.WriteLine("Enter your favorite color");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Enter your favorite animal");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("Enter your favorite music band");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"There once was an incredible human being named {nameForStory1}.");
            Console.WriteLine($"He rode around in a car that was matte {favoriteColor}");
            Console.WriteLine($"The car had a hood emblem of his favorite animal, a {favoriteAnimal}");
            Console.WriteLine($"The sound system was constantly pumping {favoriteBand}");
            Console.WriteLine($"You have {amountOfItems} of these cars");
            Console.WriteLine($"Your coin holder has {amountOfCoins} pennies");
        }
        //Exercise 2
        public static int SumOfTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int ProductOfTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
