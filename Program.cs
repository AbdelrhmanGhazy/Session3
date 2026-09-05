using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("                ASSIGNMENT 3 SOLUTIONS            ");
        Console.WriteLine("==================================================");

        // ------------------------------------------------------------------
        // Problem 1: Check if number can be divided by 3 and 4
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 1 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            if (num1 % 3 == 0 && num1 % 4 == 0)
                Console.WriteLine("Output: Yes");
            else
                Console.WriteLine("Output: No");
        }

        // ------------------------------------------------------------------
        // Problem 2: Check if number is positive or negative
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 2 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num2))
        {
            if (num2 < 0)
                Console.WriteLine("Output: negative");
            else
                Console.WriteLine("Output: positive");
        }

        // ------------------------------------------------------------------
        // Problem 3: Max and min of 3 numbers
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 3 ---");
        Console.Write("Enter 3 integers separated by spaces or commas: ");
        string input3 = Console.ReadLine();
        string[] parts3 = input3.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts3.Length >= 3)
        {
            int a = int.Parse(parts3[0]);
            int b = int.Parse(parts3[1]);
            int c = int.Parse(parts3[2]);

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"max element = {max}");
            Console.WriteLine($"min element = {min}");
        }

        // ------------------------------------------------------------------
        // Problem 4: Check if even or odd
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 4 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num4))
        {
            if (num4 % 2 == 0)
                Console.WriteLine("Output: Even");
            else
                Console.WriteLine("Output: Odd");
        }

        // ------------------------------------------------------------------
        // Problem 5: Check if character is vowel or consonant
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 5 ---");
        Console.Write("Input: ");
        char ch5 = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        if ("aeiou".Contains(ch5))
            Console.WriteLine("Output: vowel");
        else
            Console.WriteLine("Output: consonant");

        // ------------------------------------------------------------------
        // Problem 6: Print numbers from 1 to N
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 6 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num6))
        {
            Console.Write("Output: ");
            for (int i = 1; i <= num6; i++)
            {
                Console.Write(i + (i == num6 ? "" : ", "));
            }
            Console.WriteLine();
        }

        // ------------------------------------------------------------------
        // Problem 7: Multiplication table up to 12
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 7 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num7))
        {
            Console.Write("Outputs: ");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write((num7 * i) + " ");
            }
            Console.WriteLine();
        }

        // ------------------------------------------------------------------
        // Problem 8: Even numbers between 1 and N
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 8 ---");
        Console.Write("Input: ");
        if (int.TryParse(Console.ReadLine(), out int num8))
        {
            Console.Write("Output: ");
            for (int i = 2; i <= num8; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // ------------------------------------------------------------------
        // Problem 9: Calculate Power (Base^Exponent)
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 9 ---");
        Console.Write("Input (base and exponent separated by space): ");
        string[] parts9 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts9.Length >= 2)
        {
            int baseNum = int.Parse(parts9[0]);
            int exp = int.Parse(parts9[1]);
            long result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= baseNum;
            }
            Console.WriteLine($"Output: {result}");
        }

        // ------------------------------------------------------------------
        // Problem 10: Marks calculation (Total, Average, Percentage)
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 10 ---");
        Console.Write("Enter Marks of five subjects: ");
        string[] parts10 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts10.Length >= 5)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += int.Parse(parts10[i]);
            }
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100; // assuming each subject is out of 100

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}");
        }

        // ------------------------------------------------------------------
        // Problem 11: Days in a month
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 11 ---");
        Console.Write("Month Number: ");
        if (int.TryParse(Console.ReadLine(), out int month))
        {
            int days = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28, // Basic non-leap year representation
                _ => 0
            };
            Console.WriteLine($"Days in Month: {days}");
        }

        // ------------------------------------------------------------------
        // Problem 12: Simple Calculator
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 12 ---");
        Console.Write("Enter first number: ");
        double calcNum1 = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Enter second number: ");
        double calcNum2 = double.Parse(Console.ReadLine());

        double calcResult = op switch
        {
            '+' => calcNum1 + calcNum2,
            '-' => calcNum1 - calcNum2,
            '*' => calcNum1 * calcNum2,
            '/' => calcNum2 != 0 ? calcNum1 / calcNum2 : double.NaN,
            _ => double.NaN
        };
        Console.WriteLine($"Result: {calcResult}");

        // ------------------------------------------------------------------
        // Problem 13: Reverse String
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 13 ---");
        Console.Write("Enter a string: ");
        string input13 = Console.ReadLine();
        char[] charArray13 = input13.ToCharArray();
        Array.Reverse(charArray13);
        Console.WriteLine($"Reversed: {new string(charArray13)}");

        // ------------------------------------------------------------------
        // Problem 14: Reverse Integer
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 14 ---");
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int num14))
        {
            int reversedInt = 0;
            int temp = Math.Abs(num14);
            while (temp > 0)
            {
                reversedInt = (reversedInt * 10) + (temp % 10);
                temp /= 10;
            }
            if (num14 < 0) reversedInt = -reversedInt;
            Console.WriteLine($"Reversed: {reversedInt}");
        }

        // ------------------------------------------------------------------
        // Problem 15: Prime numbers within range
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 15 ---");
        Console.Write("Input starting number of range: ");
        int start15 = int.Parse(Console.ReadLine());
        Console.Write("Input ending number of range: ");
        int end15 = int.Parse(Console.ReadLine());

        Console.WriteLine($"The prime numbers between {start15} and {end15} are :");
        for (int i = Math.Max(2, start15); i <= end15; i++)
        {
            bool isPrime = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) Console.Write(i + " ");
        }
        Console.WriteLine();

        // ------------------------------------------------------------------
        // Problem 16: Decimal to Binary (without Array)
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 16 ---");
        Console.Write("Enter a number to convert: ");
        if (int.TryParse(Console.ReadLine(), out int decNum))
        {
            string binaryStr = "";
            int tempDec = decNum;
            if (tempDec == 0) binaryStr = "0";
            while (tempDec > 0)
            {
                binaryStr = (tempDec % 2) + binaryStr;
                tempDec /= 2;
            }
            Console.WriteLine($"The Binary of {decNum} is {binaryStr}.");
        }

        // ------------------------------------------------------------------
        // Problem 17: Check if three points lie on a straight line
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 17 ---");
        Console.Write("Enter x1 y1: ");
        string[] p1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter x2 y2: ");
        string[] p2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter x3 y3: ");
        string[] p3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        double x1 = double.Parse(p1[0]), y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]), y2 = double.Parse(p2[1]);
        double x3 = double.Parse(p3[0]), y3 = double.Parse(p3[1]);

        // Cross-multiplication formula to prevent division-by-zero on vertical lines:
        // (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1)
        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            Console.WriteLine("The points lie on a single straight line.");
        else
            Console.WriteLine("The points do NOT lie on a single straight line.");

        // ------------------------------------------------------------------
        // Problem 18: Worker efficiency evaluation
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 18 ---");
        Console.Write("Enter time taken for task (in hours): ");
        if (double.TryParse(Console.ReadLine(), out double hours))
        {
            if (hours >= 2 && hours <= 3)
                Console.WriteLine("Highly efficient.");
            else if (hours > 3 && hours <= 4)
                Console.WriteLine("Instructed to increase speed.");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("Provided with training to enhance speed.");
            else if (hours > 5)
                Console.WriteLine("Required to leave the company.");
            else
                Console.WriteLine("Task completed in less than 2 hours.");
        }

        // ------------------------------------------------------------------
        // Problem 19: Identity Matrix
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 19 ---");
        Console.Write("Enter size n: ");
        if (int.TryParse(Console.ReadLine(), out int n19))
        {
            for (int i = 0; i < n19; i++)
            {
                for (int j = 0; j < n19; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }

        // ------------------------------------------------------------------
        // Problem 20: Sum of array elements
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 20 ---");
        Console.Write("Enter array elements separated by spaces: ");
        int[] arr20 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int sum20 = 0;
        foreach (int val in arr20) sum20 += val;
        Console.WriteLine($"Sum of all elements = {sum20}");

        // ------------------------------------------------------------------
        // Problem 21: Merge two sorted arrays
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 21 ---");
        Console.Write("Enter first sorted array: ");
        int[] arr21_1 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        Console.Write("Enter second sorted array: ");
        int[] arr21_2 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

        int[] merged21 = new int[arr21_1.Length + arr21_2.Length];
        int idx1 = 0, idx2 = 0, mIdx = 0;

        while (idx1 < arr21_1.Length && idx2 < arr21_2.Length)
        {
            if (arr21_1[idx1] <= arr21_2[idx2])
                merged21[mIdx++] = arr21_1[idx1++];
            else
                merged21[mIdx++] = arr21_2[idx2++];
        }
        while (idx1 < arr21_1.Length) merged21[mIdx++] = arr21_1[idx1++];
        while (idx2 < arr21_2.Length) merged21[mIdx++] = arr21_2[idx2++];

        Console.WriteLine("Merged sorted array: " + string.Join(" ", merged21));

        // ------------------------------------------------------------------
        // Problem 22: Count frequency of elements
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 22 ---");
        Console.Write("Enter array elements separated by spaces: ");
        int[] arr22 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        bool[] visited22 = new bool[arr22.Length];

        for (int i = 0; i < arr22.Length; i++)
        {
            if (visited22[i]) continue;
            int count = 1;
            for (int j = i + 1; j < arr22.Length; j++)
            {
                if (arr22[i] == arr22[j])
                {
                    visited22[j] = true;
                    count++;
                }
            }
            Console.WriteLine($"{arr22[i]} occurs {count} times");
        }

        // ------------------------------------------------------------------
        // Problem 23: Max and min element in an array
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 23 ---");
        Console.Write("Enter array elements separated by spaces: ");
        int[] arr23 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        if (arr23.Length > 0)
        {
            int max23 = arr23[0], min23 = arr23[0];
            foreach (int val in arr23)
            {
                if (val > max23) max23 = val;
                if (val < min23) min23 = val;
            }
            Console.WriteLine($"Maximum element = {max23}");
            Console.WriteLine($"Minimum element = {min23}");
        }

        // ------------------------------------------------------------------
        // Problem 24: Find second largest element
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 24 ---");
        Console.Write("Enter array elements separated by spaces: ");
        int[] arr24 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        if (arr24.Length >= 2)
        {
            int firstMax = int.MinValue, secondMax = int.MinValue;
            foreach (int val in arr24)
            {
                if (val > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = val;
                }
                else if (val > secondMax && val < firstMax)
                {
                    secondMax = val;
                }
            }
            Console.WriteLine($"Second largest element = {secondMax}");
        }

        // ------------------------------------------------------------------
        // Problem 25: Longest distance between two equal cells
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 25 ---");
        Console.Write("Enter array elements separated by spaces (e.g. 7 0 0 0 5 6 7 5 0 7 5 3): ");
        int[] arr25 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int maxDistance = 0;

        for (int i = 0; i < arr25.Length; i++)
        {
            for (int j = arr25.Length - 1; j > i; j--)
            {
                if (arr25[i] == arr25[j])
                {
                    int distance = (j - i) - 1;
                    if (distance > maxDistance)
                        maxDistance = distance;
                    break;
                }
            }
        }
        Console.WriteLine($"Longest distance between equal cells = {maxDistance}");

        // ------------------------------------------------------------------
        // Problem 26: Reverse order of words (Single Console.WriteLine Statement)
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 26 ---");
        Console.Write("Input: ");
        string input26 = Console.ReadLine();
        Console.WriteLine("Output: " + string.Join(" ", input26.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));

        // ------------------------------------------------------------------
        // Problem 27: Copy 2D array to another and print
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 27 ---");
        Console.Write("Enter rows and columns (e.g. 2 3): ");
        string[] dims27 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int rows27 = int.Parse(dims27[0]);
        int cols27 = int.Parse(dims27[1]);

        int[,] arr1_27 = new int[rows27, cols27];
        int[,] arr2_27 = new int[rows27, cols27];

        Console.WriteLine("Enter elements row by row:");
        for (int i = 0; i < rows27; i++)
        {
            string[] rowVals = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < cols27; j++)
            {
                arr1_27[i, j] = int.Parse(rowVals[j]);
            }
        }

        // Copy elements
        for (int i = 0; i < rows27; i++)
        {
            for (int j = 0; j < cols27; j++)
            {
                arr2_27[i, j] = arr1_27[i, j];
            }
        }

        Console.WriteLine("Copied Second Array:");
        for (int i = 0; i < rows27; i++)
        {
            for (int j = 0; j < cols27; j++)
            {
                Console.Write(arr2_27[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // ------------------------------------------------------------------
        // Problem 28: Print 1D Array in Reverse Order
        // ------------------------------------------------------------------
        Console.WriteLine("\n--- Problem 28 ---");
        Console.Write("Enter array elements separated by spaces: ");
        int[] arr28 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

        Console.Write("Reversed Array: ");
        for (int i = arr28.Length - 1; i >= 0; i--)
        {
            Console.Write(arr28[i] + " ");
        }
        Console.WriteLine();
    }
}
