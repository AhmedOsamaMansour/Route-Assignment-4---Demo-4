using System.ComponentModel;

namespace Route_Assignment_4
{
    internal class Program
    {
        class Point
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {



            #region Session 4
            #region String VS StringBuilder 
            // string
            //string name1 = "Ahmed";
            //string name2 = new string("Osama");
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);
            //name1 = name2;
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);
            //name2 = "Rana"; // string is imutable type
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);
            ///////////////////////////////////////////////////////////////////////////////////////
            //string msg = "Hello";
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            //msg += "Route";
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            ///////////////////////////////////////////////////////////////////////////////////////
            // string Builder is mutable
            //StringBuilder msg = new StringBuilder();
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            //msg.Append("Hello");
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            //msg.Append(" Route");
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            ///////////////////////////////////////////////////////////////////////////////////////
            #endregion
            #region Array
            // one dimensional array
            //int[] number;
            //number = new int[3];
            //number[0] = 5;
            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);
            //Console.WriteLine(number[2]);
            //int[] number2 = new int[] { 1, 2 };
            //Console.WriteLine(number2[0]);
            //Console.WriteLine(number2[1]);
            //int[] number3 = { 1, 3 };
            //Console.WriteLine(number3[0]);
            //Console.WriteLine(number3[1]);

            //Console.WriteLine(number.Rank);
            //Console.WriteLine(number2.Rank);
            //Console.WriteLine(number3.Rank);

            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //int[,] numbers = new int[3,5]; 
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++) 
            //    {
            //        numbers[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] marks = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
            //Console.WriteLine(marks.Rank);
            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write(marks[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // judget array
            //int[][] numbers = new int[3][];
            //numbers[0] = new int [] {1,3,2,5};
            //numbers[1] = new int [] {2};
            //numbers[2] = new int [] {3,4,5};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(numbers[i][j]);
            //    }
            //}
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // array methods
            //int[] numbers = { 15, 24, 73, 64, 51, 66, 7, 87, 91 };
            //int [] n1 = {1,2,3,4};
            //int [] n2 = new int[5];

            ////object member method 
            ////Console.WriteLine(numbers.Length);
            //n1.CopyTo(n2, 0);
            //for (int i = 0; i < n2.Length; i++)
            //{
            //    Console.WriteLine(n2[i]);
            //}
            //n2.SetValue(100, 1);
            //Console.WriteLine(n2[1]);
            //class member method(static methods)
            //Array.Sort(numbers);
            //Array.Copy(n1, n2, 2);
            //foreach (int i in n2) {
            //    Console.WriteLine(i);
            //}
            //Array.Clear(n2);
            //Array.ConstrainedCopy(n1, 1, n2, 1, 2);
            ///////////////////////////////////////////////////////
            //int [] arr = (int []) Array.CreateInstance(typeof(int), 10);
            //int[,,] arr1 = (int[,,])Array.CreateInstance(typeof(int), 10,5,4);

            #endregion
            #endregion



            #region Assignment 4
            #region Question 1
            //Point p1 = new Point();
            //Console.WriteLine("Enter Point 1:");
            //Console.WriteLine("enter x");
            //p1.x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter y");
            //p1.y = int.Parse(Console.ReadLine());
            //Point p2 = new Point();
            //Console.WriteLine("Enter Point 2:");
            //Console.WriteLine("enter x");
            //p2.x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter y");
            //p2.y = int.Parse(Console.ReadLine());
            //Point p3 = new Point();
            //Console.WriteLine("Enter Point 1:");
            //Console.WriteLine("enter x");
            //p3.x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter y");
            //p3.y = int.Parse(Console.ReadLine());

            //if (p1.x == p2.x && p1.x == p3.x && p1.y != p2.y && p1.y != p3.y && p2.y != p3.y)
            //{
            //    Console.WriteLine("This is straight line");
            //}

            //else if (p1.y == p2.y && p1.y == p3.y && p1.x != p2.x && p1.x != p3.x && p2.x != p3.x)
            //{
            //    Console.WriteLine("This is straight line");
            //}
            //else
            //{
            //    Console.WriteLine("Not Line");
            //}

            #endregion
            #region Question 2
            /*2 - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
                - If the worker takes more than 5 hours, they are required to leave the company.
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */
            //int TaskTime = int.Parse(Console.ReadLine());
            //if (TaskTime <= 3)
            //{
            //    Console.WriteLine("they are considered highly efficient");
            //}
            //else if (TaskTime <= 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if (TaskTime <= 5)
            //{
            //    Console.WriteLine("they are provided with training to enhance their speed");
            //}
            //else if (TaskTime > 5)
            //{
            //    Console.WriteLine("they are required to leave the company");
            //}

            #endregion
            #region Question 3
            //3- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int size = int.Parse(Console.ReadLine());
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(1 + " ");
            //        }
            //        else
            //        {
            //            Console.Write(0 + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Question 4
            //20 - Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //Console.WriteLine(numbers.Sum());
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion
            #region Question 5
            //21 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] num1 = { 10, 32, 43, 14, 5, 6 };
            //int[] num2 = { 70, 85, 96, 90, 11, 12 };
            //int[] num = new int[num1.Length + num2.Length];
            //num1.CopyTo(num, 0);
            //num2.CopyTo(num, num1.Length);
            //Array.Sort(num);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            #endregion
            #region Question 6
            //22 - Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] numbers = { 1, 2, 3, 4, 2, 4, 3, 5, 8, 1, 2, 1, 3, 8, 9, 4, 6, 7, 1, 2, 3, 5 };
            //// optimal solution is dictionary (map)
            //Dictionary <int,int> freqMap = new Dictionary<int,int>();
            //foreach (int num in numbers)
            //{
            //    if (freqMap.ContainsKey(num)) 
            //    {
            //        freqMap[num]++;
            //    }
            //    else
            //    {
            //        freqMap[num] = 1;
            //    }
            //}
            //int[] keys;
            //int [] values;
            //Console.WriteLine(numbers.Distinct());
            //foreach (KeyValuePair<int,int> keyValue in freqMap)
            //{
            //    Console.WriteLine(keyValue.Key+ " " +keyValue.Value);
            //}

            #endregion
            #region Question 7
            // 23- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] number = { 1, 4, 8, 10, 9, 4, 7, 5, 6, 2, 1, 10, 100 };
            //Console.WriteLine(number.Max());
            //Console.WriteLine(number.Min());
            #endregion
            #region Question 8
            // 24- Write a program in C# Sharp to find the second largest element in an array.
            //int[] number = { 500, 400, 10, 100,101 };
            //int n = number.Max();
            //int secondN = number[0];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (n == secondN)
            //    {
            //        secondN = number[1];
            //    }
            //    if (secondN <= number[i]  && number[i] != n ) { 
            //        secondN = number[i];
            //    }

            //}
            //Console.WriteLine(secondN);
            ///////// or ////////
            //Array.Sort(number);
            //Console.WriteLine(number[number.Length -2]);
            #endregion
            #region Question 9
            // 25-. Consider an Array of Integer values with size N, having values as in this Example
            Console.WriteLine("Enter Size Of Array:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // i will store first occure of number and update this store if show again
            Dictionary<int, int> firstIndexMap = new Dictionary<int, int>();
            int maxDistance = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (firstIndexMap.ContainsKey(numbers[i]))
                {
                    int distance = i - firstIndexMap[numbers[i]];
                    maxDistance = Math.Max(maxDistance, distance);
                }
                else
                {
                    firstIndexMap[numbers[i]] = i;
                }
            }
            Console.WriteLine("longest distance equal : " + maxDistance);
            #endregion
            #region Question 10
            //26- Given a list of space separated words, reverse the order of the words.
            //string sentence = Console.ReadLine();
            //string [] words = sentence.Split(" ");
            //int len = words.Length;
            //Console.WriteLine();
            //for (int i = 0; i < len; i++)
            //{
            //    Console.Write(words[len - i - 1]);
            //}
            #endregion
            #region Question 11
            // 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int[,] firstArr = new int[3,4];
            //for (int i = 0; i < firstArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArr.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Enter intger Value:");
            //        firstArr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int [,] secondArr = (int[,])Array.CreateInstance(typeof(int), 3 , 4);
            //Console.WriteLine();
            //for (int i = 0; i < firstArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArr.GetLength(1); j++)
            //    {
            //        secondArr[i,j]= firstArr[i,j];
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < firstArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArr.GetLength(1); j++)
            //    {
            //        Console.Write(secondArr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            /* OR */






            //int[,] firstArr = new int[3, 4];
            //for (int i = 0; i < firstArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArr.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Enter intger Value:");
            //        firstArr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int[,] secondArr = (int[,])Array.CreateInstance(typeof(int), 3, 4);
            //Array.Copy(firstArr, secondArr,firstArr.Length);

            //for (int i = 0; i < firstArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArr.GetLength(1); j++)
            //    {
            //        Console.Write(secondArr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region Question 12
            //28- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            ////////////////////////////// or //////////////////////////////////
            //int temp;
            //int len = numbers.Length;
            //for (int i = 0; i < (numbers.Length)/2; i++) { 
            //    temp = numbers[i];
            //    numbers[i] = numbers[len - i -1];
            //    numbers[len - i - 1] = temp;
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #endregion

        }
    }
}
