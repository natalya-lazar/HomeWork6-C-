//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//Решение:
/*int [] CreateNewArray (int size)
{  int [] array = new int [size]; 
    for (int i = 0; i < size; i ++)
        {Console.WriteLine("Input array element: ");
         int elem = Convert.ToInt32(Console.ReadLine());
         array[i] = elem;
        }
   return array;     
}
void ShowArray (int [] array)
{ for (int i = 0; i < array.Length; i ++)
    {Console.Write(array[i] + " ");};
  Console.WriteLine();  
}
int CountElements (int [] array)
{ int count = 0;
    for (int i = 0; i < array.Length; i ++)
     {if (array[i] > 0)
      count += 1;}
  return count;
}
Console.WriteLine("Input array size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
int [] createdArray = CreateNewArray(user_size);
ShowArray(createdArray);
Console.WriteLine($"Number of positive array elements is {CountElements(createdArray)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//Решение:
//k1 * x + b1 = k2 * x + b2
//k1 * x - k2 * x = b2 - b1
//x * (k1 - k2) = b2 - b1
//x = (b2 - b1) / (k1 - k2)

void Cusp (int b1, int k1, int b2, int k2)
{   double x1 = (b2 - b1);
    double x2 = (k1 - k2);
    double x = x1 / x2;
    double y = k1 * x + b1;
    Console.WriteLine($"Coordinates of the point of intersection of two given lines is [{x};{y}]");
}
Console.WriteLine("Input b1: ");
int user_b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int user_k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int user_b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int user_k2 = Convert.ToInt32(Console.ReadLine());
Cusp(user_b1, user_k1, user_b2, user_k2);