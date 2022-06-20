//**Задача 32:** Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]


using System;
using static System.Console;
Clear();


int size=int.Parse(ReadLine());
int Max=int.Parse(ReadLine());
int Min=int.Parse(ReadLine());
int[] array= new int[size];
array=GetRandomArray(size,Min,Max);
WriteLine($"Массив= {string.Join(",",array)}");
WriteLine($"Массив инверсный= {string.Join(",",GetReversPositivAraay(array))}");


int[] GetRandomArray(int size,int MinValue,int MaxValue)
{
    int[] result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(MinValue,MaxValue+1);
    }
    return result;
}

int[] GetReversPositivAraay(int[] array)
{
    int size=array.Length;
    int []ar= new int[size];
    for(int i=0;i<size;i++)
    {
        ar[i]=array[i]*-1;
    }
    return ar;
}
