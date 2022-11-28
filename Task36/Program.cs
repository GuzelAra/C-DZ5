// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
    {
        int[] arr=new int[size];
        for (int i=0; i<arr.Length; i++)
        {
            arr[i]=new Random().Next(0,10);
        }
        return arr;
    }

Console.WriteLine("Введите длину массива");
int num=Convert.ToInt32(Console.ReadLine());
int[]array=FillArray(num);
Console.WriteLine(string.Join(", ",array));
int count=0;
int sum=0;
for (int i=0; i<array.Length; i++)
{
    if (i%2==1)
    {sum=sum+array[i];
        count++;}
    else
    {count++;}
}
Console.WriteLine(sum);