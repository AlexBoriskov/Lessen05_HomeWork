// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Massiv (int [] array)
{
    for (int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next (-10,11);
    }
}

int Summa (int [] array)
{
    int s=0;
    for (int i=1; i<array.Length; i=i+2)
    {
        s += array[i];
    }
    return s;
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
Massiv (array);
Console.WriteLine (string.Join(", ", array));
Console.WriteLine ("Сумма позиций на четных местах = " + Summa(array));




