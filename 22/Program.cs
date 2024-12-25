using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Formats.Asn1.AsnWriter;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)

        {


            #region 1
            //1 - Write a program that takes a number from the user then print yes if that number
            //can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 12 == 0)
            //    Console.WriteLine("this number can be divided by 3 and 4");
            //else
            //    Console.WriteLine("no");
            #endregion
            #region 2
            //2 - Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.
            //    Example(1)
            //    Input: -5
            //    Output: negative
            //    Example(2)
            //    Input: 10
            //    Output: positive
            //Console.WriteLine("please enter number");
            //int num=int.Parse(Console.ReadLine());
            //if (num >= 0)
            //    Console.WriteLine("positive number");
            //else 
            //    Console.WriteLine("negative number");            
            #endregion


            #region 3
            //3 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.
            //    Example(1)
            //    Input: 7,8,5
            //    Output:
            //            max element = 8
            //    min element = 5
            //    Example(2)
            //    Input: 3 6 9
            //    Outputs:
            //            Max element = 9
            //    Min element = 3
            //Console.WriteLine("enter three numbers");
            //int num1 = int.Parse(Console.ReadLine());            
            //int num2 = int.Parse(Console.ReadLine());            
            //int num3 = int.Parse(Console.ReadLine());
            //int min;
            //int max;
            //if (num1 > num2 && num1 > num3) 
            // max = num1; 
            //else if (num2 > num1 && num2 > num3)
            //     max = num2; 
            //else
            // max = num3;   
            //if (num1 < num2 && num1 < num3) 
            // min = num1; 
            //else if (num2 < num1 && num2 < num3)
            //     min = num2; 
            //else
            // min = num3;
            //Console.WriteLine($"max number is =>{max}");  
            //Console.WriteLine($"min number is =>{min}");  
            #endregion

            #region 4
            //4 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.
            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num %2== 0)
            //    Console.WriteLine("even number");
            //else
            //    Console.WriteLine("odd number");
            #endregion

            #region 5
            //5 - Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //    Example(1)
            //    Input: O
            //    Output: vowel
            //    Example(2)
            //    Input: b
            //    Output: Consonant
            //Console.WriteLine("please enter char");
            //char character1 =char.Parse(Console.ReadLine());
            //switch (character1)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'u':
            //    case 'i':
            //    case 'o':
            //         Console.WriteLine("vowel char");
            //        break;
            //    default:
            //        Console.WriteLine("consonant char");
            //        break;
            //}

            #endregion


            #region 6
            //6 - Write a program that allows the user to insert an integer then print all
            //numbers between 1 to that number.
            //    Example
            //    Input: 5
            //    Output: 1, 2, 3, 4, 5
            // Console.WriteLine("please enter integer number");
            //int number = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= number; i++)
            // {
            //     Console.WriteLine(i);
            // }


            #endregion

            #region 7
            //7 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //    Example
            //    Input: 5
            //    Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //Console.WriteLine("please enter integer number");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*number);
            //}

            #endregion

            #region 8
            //8 - Write a program that allows to user to insert number then print all even
            //numbers between 1 to this number
            //    Example:
            //    Input: 15
            // Output: 2 4 6 8 10 12 14
            //Console.WriteLine("please enter integer number");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 9
            //9 - Write a program that takes two integers then prints the power.
            //    Example:
            //        Input: 4 3
            //    Output: 64
            //    Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64
            //Console.WriteLine("please enter integer number");
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //    double  power = Math.Pow(number1, number2);

            //Console.WriteLine(power);


            #endregion

            #region 10
            //10 - Write a program to enter marks of five subjects and calculate total,
            //average and percentage.
            //    Example
            //    Input: -Enter Marks of five subjects: 95 76 58 90 89
            //    Output: Total marks = 408
            //            Average Marks = 81
            //            Percentage = 81
            //Console.WriteLine("please enter marks of five subjects");
            //int number = 0;
            //for (int i = 0; i < 5; i++)
            //{

            //    number += int.Parse(Console.ReadLine());
            //}
            //    Console.WriteLine($"total number{number}");
            //    double average = number / 5;
            //Console.WriteLine($"average {average}"); 
            //double percentage = (number *100)/ 100;
            //Console.WriteLine($"percentage {percentage}%");




            #endregion

            #region 11
            //11 - Write a program to input the month number and print the number of days in
            //that month.
            //    Example
            //    Input: Month Number: 1
            //    Output: Days in Month: 31
            //Console.WriteLine($"please enter month number");

            //int monthnum =int.Parse(Console.ReadLine());
            //switch (monthnum)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //        Console.WriteLine($"number of days in month {monthnum} is 31 days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"number of days in month {monthnum} is 30 days");
            //        break;
            //    case 2:
            //        Console.WriteLine($"number of days in month {monthnum} is 28 days");
            //        break;
            //}
            #endregion

            #region 12
            //12 - Write a program to create a Simple Calculator.
            //Console.WriteLine("please enter two numbers");
            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());

            //int sum = 0;
            //int multi = 1;
            //int sub;
            //double div;
            //char op;
            //Console.WriteLine("please enter simple operation");
            //char opp = char.Parse(Console.ReadLine());

            //switch (opp)
            //{
            //    case '+':
            //        sum=num1 + num2;
            //        Console.WriteLine($"addition result is {sum}");
            //        break; 
            //    case '-':
            //        sub=num1 - num2;
            //        Console.WriteLine($" sub result is {sub}");
            //        break; 
            //    case '*':
            //        multi=num1 * num2;
            //        Console.WriteLine($" multi result is {multi}");
            //        break; 
            //    case '/':
            //        div=num1 / num2;
            //        Console.WriteLine($" div result is {div}");
            //        break;     
            //    case '^':
            //        double poww = Math.Pow(num1, num2);
            //        Console.WriteLine($" power result is {poww}");
            //        break;
            //        default:
            //        Console.WriteLine("sorry");
            //        break;

            //}
            #endregion

            #region 13
            //13 - Write a program to allow the user to enter a string and print the
            //REVERSE of it.
            //Console.WriteLine("please enter string");
            //string word = Console.ReadLine();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    string reversee = null;
            //    reversee += word[i];
            //    Console.Write(reversee);
            //}
            #endregion

            #region 14
            //14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("please enter integer");
            //int num =int.Parse( Console.ReadLine());
            //Console.WriteLine($"the Additive inverse is =>{-num}");
            //Console.WriteLine("................................");
            //string word =num.ToString();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    string reversee = null;
            //    reversee += word[i];
            //    Console.Write(reversee);
            //}
            #endregion

            #region 15

            //15 - Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Test Data:
            //Input starting number of range: 1
            //Input ending number of range: 50

            //Expected Output :
            //The prime number between 1 and 50 are:
            //            2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            //Console.WriteLine("please enter  start and end of  range");
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2)
            //        continue;
            //    bool isPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;

            //        }
            //    }
            //    if (isPrime)
            //        Console.Write(i + " ");

            //}

            #endregion

            //16 - .Write a program in C# Sharp to convert
            //a decimal number into binary without using an array.
            //Test Data:
            // Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.





            #region 17
            //17 - Create a program that asks the user to input three
            //points(x1, y1)
            //, (x2, y2), and(x3, y3), and determines whether these points
            //lie on a single
            //straight line.
            //Console.WriteLine("please enter three points");
            //int x1=int.Parse(Console.ReadLine());  
            //int y1=int.Parse(Console.ReadLine());     
            //int x2=int.Parse(Console.ReadLine());      
            //int y2=int.Parse(Console.ReadLine());      
            //int x3=int.Parse(Console.ReadLine());   
            //int y3=int.Parse(Console.ReadLine());
            //int ab = x2 - x1;
            //int ab1= y2 - y1;
            //int bc = x3 - x2;
            //int bc1 = y3 - y2;
            //if ((bc / ab) == (bc1 / ab1))
            //{
            //    Console.WriteLine(" these points lie on a single");
            //}
            //else
            //{
            //    Console.WriteLine(" these points dont lie on a single");
            //}



            #endregion

            #region 18


            //18 - Within a company, the efficiency of workers is evaluated
            //based on the duration required to complete a specific task.A worker's efficiency level
            //is determined as follows: 
            //- If the worker completes the job within 2 to 3 hours, they are considered
            //highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance
            //their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is
            //obtained via user input from the keyboard.
            //Console.WriteLine("enter the time taken for the task ");
            //double timee = double.Parse(Console.ReadLine());

            //if (timee >= 2 && timee <= 3)
            //    Console.WriteLine("workers are considered highly efficient");
            //if (timee > 3 && timee <= 4)
            //    Console.WriteLine("workers are instructed to increase their speed");
            //else if (timee > 4 && timee <= 5)
            //    Console.WriteLine(" workers are provided with training to enhance their speed");
            //else if (timee > 5)
            //    Console.WriteLine(" workers required to leave the company");
            #endregion
            //19 - .Write a program that prints an identity matrix using for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.


            #region 20
            //20 - Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3, 4 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //    Console.WriteLine(sum);
            #endregion

            #region 21
            //21 - Write a program in C# Sharp to merge two arrays of the same
            //size sorted in ascending order.
            //int[] arr1 = { 2, 3, 4, 6 };
            //int[] arr2 = { 1, 2, 3, 4 };
            //int[] merge = new int[8];
            //int k =0;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    merge[k++] = arr1[i];
            //}
            //    for (int j = 0; j < arr2.Length; j++)
            //    {

            //    merge[k++] = arr2[j];
            //}
            //    Array.Sort(merge);


            //for (int i = 0; i < merge.Length; i++)
            //{
            //    Console.WriteLine(merge[i]);
            //}
            #endregion

            #region 22
            //22 - Write a program in C# Sharp to count the frequency of each element
            //of an array.
            //int[] numbers = { 1, 1, 1, 1, 2, 2, 3, 3, 3 };

            //for (int i = 0; i < numbers.Length; i++)
            //  {
            //    int count = 0;
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //            count++;                      
            //    }
            //    Console.WriteLine($"{numbers[i]}is repeated {count}");
            //    }
            #endregion

            #region 23
            //23 - Write a program in C# Sharp to find maximum and minimum
            //element in an array
            //int[] arr = {  2, 3, 4,  6, 5, 1, 10, 7 };
            //Array.Sort(arr);
            // int min = 0;
            //int max = 0;
            //min = arr[0];
            //max = arr[arr.Length-1];
            //Console.WriteLine(min);
            //Console.WriteLine(max);


            #endregion

            #region 24
            //24- Write a program in C# Sharp to find the second largest element in an array.
            //  int[] arr = { 2, 3, 10,4, 6, 5, 1, 10, 7 };
            //  Array.Sort(arr);

            //  int secondmax = 0;
            //  if (arr[arr.Length - 1] > arr[arr.Length - 2])

            //  secondmax = arr[arr.Length - 2];
            //if (arr[arr.Length - 1] == arr[arr.Length - 2])

            //      secondmax = arr[arr.Length - 3];


            //  Console.WriteLine(secondmax);

            #endregion

            #region 25
            //            25 -.Consider an Array of Integer values with size N, having values as
            // in this Example

            //7      0    0   0   0   5   6   7   5   0   7   5   3

            //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).

            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.

            //Console.WriteLine("please enter array size");
            //  int arrsize = int.Parse(Console.ReadLine());
            //  Console.WriteLine("please enter array of number has 2 equal integers");
            //            int[] arr = new int[arrsize];
            //            int maxdistance=0;
            //            for(int i = 0;i<arr.Length; i++)
            //            {

            //                int push ;
            //                push= int.Parse(Console.ReadLine());
            //                arr[i] = push;
            //            }
            //            //7      0    0   0   0   5   6   7   5   0   7   5   3

            //            for (int i = 0; i < arr.Length; i++)
            //            {
            //                for (int j = i+1; j < arr.Length; j++)
            //                {
            //                    int distance = j - i;
            //                    if (arr[i] == arr[j ])
            //                    {

            //                        if (distance > maxdistance)
            //                        {
            //                            maxdistance = distance;
            //                        }
            //                    Console.WriteLine($"the max distance between {arr[i]},{arr[j]}is {distance}");

            //                    }
            //                }
            //            }

            #endregion

            #region 26
            //            26 - Given a list of space separated words, reverse the order of the words.

            //Input: this is a test       Output: test a is this
            //Input: all your base        Output: base your all
            //Input: Word Output: Word
            //Note : 
            //Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement
            Console.WriteLine("please enter words");
            string word = Console.ReadLine();
          string[] words=word.Split(' ');

            string rev = null;
            for (int i = words.Length - 1; i >= 0; i--)
            {

                rev += words[i];
                if (i > 0)
                {
                    rev += " "; // Add space between words
                }

            }
            Console.WriteLine(rev);
        


            #endregion


            #region 27
            //27 - Write a program to create two multidimensional arrays of same size. Accept
            //value from user and store them in first array. Now copy all the elements of first
            //array on second array and print second array.
            //Console.WriteLine("please enter 2arrays from same size enter columns number and rows number");
            //int rownum = int.Parse(Console.ReadLine());
            //int colnum = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[rownum,colnum];
            //int[,] arr2 = new int[rownum,colnum];
            //int maxdistance = 0;
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    Console.WriteLine("please enter row elements ");
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {


            //        arr1[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////           for (int i = 0; i < arr1.GetLength(0); i++)
            ////{
            ////    for (int j = 0; j < arr1.GetLength(1); j++)
            ////    {
            ////        Console.WriteLine(arr1[i,j]);
            ////    }
            ////} 
            //Console.WriteLine("array2 elements ");

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {


            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //           for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr2[i,j]);
            //    }
            //}

            #endregion



            #region 28
            //int[] h = [1, 2, 3, 4, 5];
            //Array.Reverse( h );
            //for (int i = 0; i < h.Length; i++)
            //{
            //    Console.WriteLine(h[i]);
            //}
            #endregion











        }
    }

        }
  
