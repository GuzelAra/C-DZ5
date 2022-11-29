// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

int[] FillArray(int size)
    {
        int[] arr=new int[size];
        for (int i=0; i<arr.Length; i++)
        {
            arr[i]=new Random().Next(-50,100);
        }
        return arr;
    }

Console.WriteLine("Введите длину массива");
int num=Convert.ToInt32(Console.ReadLine());
int[]array=FillArray(num);
Console.WriteLine(string.Join(", ",array));
int count=0;
for (int i=0; i<array.Length; i++)
{
    if (9<array[i] && array[i]<100)
    {count++;}
}
if (count>=0)
{Console.WriteLine($"{count} элементов лежат в отрезке [10,99]");}
else
{Console.WriteLine("0 элементов лежат в отрезке [10,99]");}