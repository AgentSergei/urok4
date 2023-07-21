//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            
            int result, enterNumber;
            Console.Write("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.Write("Введите любое число: ");
            enterNumber = Convert.ToInt32(Console.ReadLine());
            result = 0;
            while (enterNumber != 0)
            {
                result += enterNumber % 10;
                enterNumber /= 10;
            }

            Console.WriteLine("Sum of numbers = {result}");

   


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    Console.Write("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
  Console.Write("Введите число   : ");
  int num = int.Parse(Console.ReadLine());
  //степень числа
  Console.Write("Введите степень : ");
  int n = int.Parse(Console.ReadLine());
  //число, возведенное в степень
  int num_n=1;
  for(int i=0; i<n; i++) {
   num_n*=num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  Console.ReadKey();
  return 0;

  


   
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.WriteLine("Введите длинну массива: ");
int array = int.Parse(Console.ReadLine()); 
int[] a = new int[array];

Console.WriteLine("Введите массив чисел: ");
for (int i = 0; i < a.Length; i++)
{
a[i] = int.Parse(Console.ReadLine());
}
 
foreach (int j in a)
{
Console.Write(j + " ");
}
