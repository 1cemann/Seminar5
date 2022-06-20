//**Задача 35:** Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


using System;
using static System.Console;
Clear();


int size=int.Parse(ReadLine());
int left=int.Parse(ReadLine());
int right=int.Parse(ReadLine());
int[] array= new int[size];
array=GetRandomArray(size,left,right);

WriteLine($"Массив= {string.Join(",",array)}");
WriteLine($"Количество элементов лежащих в промежутке= {string.Join(",",FindNumbArray(array, left, right))}");



int[] GetRandomArray(int size,int MinValue,int MaxValue)
{
    int[] result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(MinValue,MaxValue);
    }
    return result;
}

int FindNumbArray(int[] array,int left,int right)
{
    int result=0;
    for(int i= 0;i<array.Length; i++)
    {
        if(array[i]>left&&array[i]<right)
        {
            result++;
        }
    }
    return result;
}