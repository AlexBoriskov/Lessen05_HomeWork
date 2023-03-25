// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Chet (int [] array)
{
    int c = 0;
    for (int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next (100,1000);
        if (array[i]%2==0) 
        {
            c++;
        }
    }
    return c;
}

Console.Clear();

Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a<0)
{
    Console.WriteLine ("Ошибка!!! Введите положительное число!!!");
    Console.Write("Введите размер массива: ");
    a = Convert.ToInt32(Console.ReadLine());
}

int [] array = new int [a];

Console.WriteLine ("Количество четных чисел в массиве = " + Chet(array));
Console.WriteLine (string.Join(", ", array));


