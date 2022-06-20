//**Задача 33:** Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

//4; массив [6, 7, 19, 345, 3] -> нет

//3; массив [6, 7, 19, 345, 3] -> да

//!!!!!!!!!!!!! int[] GetArrayFromString(string arrayStr)
//{
//    string[] arS=arrayStr.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//    int[] result=new int[arS.Length];
//    for(int i=0; i<arS.Length;i++)
//    {
//        result[i]=int.Parse(arS[i]);
//    }
  //  return result;
//}
//           Способ избавиться от пустых значений!!!!!!!!!!!!!!!!!


using System;
using static System.Console;
Clear();
Write("Введите длину массива   ");
int size=int.Parse(ReadLine());
Write("Введите Мах значение в массиве   ");
int Max=int.Parse(ReadLine());
Write("Введите Мин значение в  массиве   ");
int Min=int.Parse(ReadLine());
Write("Введите искомый элемент   ");
int El=int.Parse(ReadLine());
int[] array= new int[size];
array=GetRandomArray(size,Min,Max);
WriteLine($"Массив= {string.Join(",",array)}");
if(GetFindElement(array,El)==true){WriteLine($"Данный елемент присутствует в массиве");}else{
WriteLine($"Данный елемент отсутствует в массиве");}


int[] GetRandomArray(int size,int MinValue,int MaxValue){
    int[] result=new int[size];
    for(int i=0;i<size;i++){
        result[i]=new Random().Next(MinValue,MaxValue);
    }
    return result;
}

bool GetFindElement(int[] array,int Element){
    for(int i=0;i<array.Length;i++){
        if(array[i]==Element){return true;}
    }
    return false;
}
