# pragma warning disable

// Домашнее задание к уроку 7
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

/*
int numM = new Random().Next(1,10);
int numN = new Random().Next(1,10);
Console.Write($"M = {numM}; N = {numN} -> ");

if (numM < numN)
{
   PrintNumbers(numM,numN);
}
else
{
   PrintNumbers(numN,numM);
}

void PrintNumbers(int startElement,int endElement)
{
   if (startElement == endElement)
   {
      Console.Write(startElement);
      return;
   }
   else
   {
      Console.Write(startElement +", ");
      PrintNumbers(startElement+1, endElement);
   }
}
*/


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
/*
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackermann(m,n)}");
int Ackermann (int newM, int newN)
{
   if (newM == 0)
   {
      return newN + 1;
   }
   else if (newM > 0 && newN == 0)
   {
      return Ackermann(newM - 1, 1);
   }
   else if (newM > 0 && newN > 0)
   {
      return Ackermann(newM - 1, Ackermann(newM, newN - 1));
   }

   return 0;
}
*/

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

/*
Console.WriteLine("Введите размер массива");
int N = int.Parse(Console.ReadLine());

int [] array = new int[N];

void CreateArray(int [] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0,101);
   }
}

void PrintArray()
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("] => ");
}

CreateArray(array);
PrintArray ();

int i = N-1;
PrintReverseArray(array, i);
void PrintReverseArray(int[] newArray, int index)
{
   if(index < 0)
   {
      return;
   }
   Console.Write($"{newArray[index]} ");
   PrintReverseArray(newArray, index-1);
}
*/
