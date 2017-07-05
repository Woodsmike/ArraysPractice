﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            //int[] myFirstArray;

            //declare and intialize an array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };

            //declare and initialize a char array with the letters of my last name
            //char[] myCharArray = { 'W', 'o', 'o', 'd', 's' };
            //Print to console 3 elements of my display
            //Console.WriteLine(myCharArray[0]);
            //Console.WriteLine(myCharArray[2]);
            //Console.WriteLine(myCharArray[4]);
            //Create the following arrays and print using the correct index numbers.

            //Array of the top 10 vacation spots
            //print the first and last vacation spots
            //string[] vacationSpots = {"Myrtle Beach","Hawaii","Las Vegas","San Diego","Tokyo",
            //    "Cozumel","Jamaica","Paris","Mexico","Chile"};
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //Array or the ages of 3 children you know
            //print each child's age
            //int[] childAge = { 14, 16, 18 };
            //Console.WriteLine(childAge[0]);
            //Console.WriteLine(childAge[1]);
            //Console.WriteLine(childAge[2]);

            //Array of GPA's on a 4.0 scale of 8 students - you don't have to print
            //double[] studentGPAs = { 3.0d, 3.4d, 2.8d, 5.0d, 3.6d, 1.5d, 3, 9d, 3.3d };

            //Array of the First Letter of 4 of your classmate's names who are sitting 
            //near you
            //print all four on the same line
            //char[] firstLetter = { 'H', 'S', 'I', 'P' };
            //Console.Write(firstLetter[0]);
            //Console.Write(firstLetter[1]);
            //Console.Write(firstLetter[2]);
            //Console.Write(firstLetter[3]);
            //Console.WriteLine();
            //Console.WriteLine("{ 0},{ 1},{ 2},{ 3}", firstLetter[0], firstLetter[1], firstLetter[2], firstLetter[3]);

            //data type[] nameOfArray = new data type[number of places held] 
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {0}.", studentsInClass[1]);

            //Console.WriteLine("Please enter the age of the person in the first seat.");
            //int[] ageOfStudentsInClass = new int[21];
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0] +".");

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts",
            //    "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(restaurantsInMall.Length);

            //char array of letters in your middle name
            //print the number of char's to console
            //char[] middleName = { 'M', 'i', 'k', 'e' };
            //Console.WriteLine(middleName.Length);

            //Declare and initialize a string property.
            //Using the length property, print the second to last element in the array
            //property does not need () at the end

            //string[] last = { "my", "last", "chance", "try" };
            //int numLast = last.Length;
            //Console.WriteLine(last[last.Length - 2]);

            //index of is a method used to search an array for a specified value
            //and returns the index position of the first matching value found.
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            //LastIndexOf is a method used to search an array for a specified
            //value and returns the index position of the Last matching value found.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);

            //Sort
            //will sort numbers in an array from lowest to highest
            //Will sort char's and strings in alphabetical order a-z

            //string[] powerRangers = { "Green", "Yellow", "Pink", "Red", "Black" };
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            string[] firstNames = { "Mike", "Shawn", "Hope", "Iris", "Bob" };
            Console.WriteLine(firstNames[2]);

            int[] luckyNumbers = { 7, 77, 777, 3, 7, 333, 77, 1, 23, 777, 3, 1, 23 };
            Console.WriteLine(luckyNumbers[luckyNumbers.Length - 3]);

            char[] alphaLetters = { 'a', 'g', 's', 't', 'c', 'd', 'f' };
            Console.WriteLine(alphaLetters[0]);
            Array.Reverse(alphaLetters);
            Console.WriteLine(alphaLetters[0]);

            string[] studentNames = { "Mike", "Shawn", "Hope", "Iris", "Bob" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Array.Reverse(studentNames);
            Console.WriteLine(studentNames[0]);

            int[] favNumbers = { 7, 77, 777, 3, 7, 333, 75, 1, 23, 13 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);
            Array.Reverse(favNumbers);
            Console.WriteLine(favNumbers[0]);



            

        }
    }
}
