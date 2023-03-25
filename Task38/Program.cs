// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Massiv (int [] array)
{
    for (int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

int MinMax (int [] array)
{
    int minimum = array[0];
    int maximum = array[0];
    for (int i=1; i<array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    int res = maximum - minimum;
    return res;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a==0) 
{
    Console.WriteLine ("Массив пуст!!!");
}
else
{
while (a<0)
{
    Console.WriteLine ("Ошибка!!! Введите положительное число!!!");
    Console.Write("Введите размер массива: ");
    a = Convert.ToInt32(Console.ReadLine());
}

int [] array = new int [a];
Massiv (array);
Console.WriteLine (string.Join(", ", array));
Console.WriteLine ("Разница между макс. и мин. элементом = " + MinMax(array));
}