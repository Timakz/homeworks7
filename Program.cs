//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

//Console.Write("Enter the dimension m array");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the dimension n array");
//int n = Convert.ToInt32(Console.ReadLine());
//double[,] randomArray = new double[m,n];

//void mas(int m, int n)
//{
//int i,j;
//Random rand = new Random();
//for (i = 0; i < m; i++)
//{
//Console.WriteLine();
//for (j = 0; j < n; j++)
//{
//randomArray[i,j] = rand.NextDouble();
//Console.Write($»{randomArray[i,j]:F2} «);
//}

//}

//}

//mas(m,n);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

//Console.Write("Enter the dimension m array");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the dimension n array");
//int n = Convert.ToInt32(Console.ReadLine());
//double[,] randomArray = new double[m,n];
//Console.Write("Enter the line position");
//int m2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the column position");
//int n2 = Convert.ToInt32(Console.ReadLine());
//void mas(int m, int n)
//{
//int i,j;
//Random rand = new Random();
//for (i = 0; i < m; i++)
//{
//Console.WriteLine();
//for (j = 0; j < n; j++)
//{
//randomArray[i,j] = rand.NextDouble();
//Console.Write($»{randomArray[i,j]:F2} «);
//}
//Console.WriteLine();
//}
//}
//mas(m,n);
//if (m2<1 || n2<1)
//Console.Write("Row positions cannot be negative");
//else if (m2 <= m+1 && n2 <= n+1)
//Console.Write($"The value of the element is {randomArray[m2-1,n2-1]:F2} ");
//else Console.Write("There is no such element in the array");

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Random random = new Random();
//int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
//for (int i = 0; i < arr.GetLength(0); i++)
//{
  //  for (int j = 0; j < arr.GetLength(1); j++)
   // {
    //    arr[i, j] = random.Next(1, 10);
     //   Console.Write(arr[i, j] + " ");
    //}
    //Console.WriteLine();
//}
//Console.WriteLine("---------------------------");
//Console.WriteLine(arr.GetLength(0));
//for (int j = 0; j < arr.GetLength(1); j++)
//{
 //   double sum = 0;
   // for (int i = 0; i < arr.GetLength(0); i++)
    //{
      //  sum += arr[i, j];
    //}
    //Console.Write($"{ sum / arr.GetLength(0)} ");
//}
//Console.ReadLine();