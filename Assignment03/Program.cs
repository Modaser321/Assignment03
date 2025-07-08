namespace Assignment03
{

    class program
    {
        static void Main(string[] args)
        {




            #region Q1
            //Console.Write("Enter the value of n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($" Identity matrix of size {n} x {n}: ");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write(" 1 ");
            //        else
            //            Console.Write(" 0 ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q2
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //    sum += array[i];
            //}

            //Console.WriteLine($"\nThe sum of all elements in the array is: {sum}");
            #endregion

            #region Q3
            //int[] array1 = { 3, 8, 1, 5, 2 };
            //int[] array2 = { 7, 4, 6, 0, 9 };

            //Console.WriteLine("First array:");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}

            //Console.WriteLine("\nSecond array:");
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.Write(array2[i] + " ");
            //}
            //int[] mergedArray = new int[array1.Length + array2.Length];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    mergedArray[i] = array1[i];
            //    mergedArray[i + array1.Length] = array2[i];
            //}
            //Array.Sort(mergedArray);

            //Console.WriteLine("\n\nMerged and sorted array:");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write(mergedArray[i] + " ");
            //}

            //Console.WriteLine();
            #endregion

            #region Q4
            //int[] array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            //int max = array[0];
            //int min = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //        max = array[i];
            //    if (array[i] < min)
            //        min = array[i];
            //}

            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion

            #region Q5

            //int[] array = { 5, 12, 7, 20, 8, 20, 3 };

            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        secondMax = max;
            //        max = array[i];
            //    }
            //    else if (array[i] > secondMax && array[i] != max)
            //    {
            //        secondMax = array[i];
            //    }
            //}

            //Console.WriteLine("Second largest element: " + secondMax);

            #endregion

            #region Q6
            //Console.WriteLine("Enter array elements separated by space:");
            //string input = Console.ReadLine();
            //string[] tokens = input.Split(' ');
            //int[] arr = new int[tokens.Length];

            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    arr[i] = int.Parse(tokens[i]);
            //}

            //Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            //int maxDistance = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!firstIndex.ContainsKey(arr[i]))
            //    {
            //        firstIndex[arr[i]] = i;
            //    }
            //    else
            //    {
            //        int distance = i - firstIndex[arr[i]];
            //        if (distance > maxDistance)
            //            maxDistance = distance;
            //    }
            //}

            //Console.WriteLine("Maximum distance between two equal elements: " + maxDistance);
            #endregion

            #region Q7
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region Q8
            //int[,] firstArray = new int[2, 3];   
            //int[,] secondArray = new int[2, 3];

            //Console.WriteLine("Enter elements of the first array:");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}


            //Console.WriteLine("Elements of the second array:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q9
            //int[] array = { 100, 200, 300, 400, 500 };

            //Console.WriteLine("Array in reverse order:");

            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            #endregion
        }

        
    }

}
           