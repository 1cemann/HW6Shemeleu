//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



using System;
using static System.Console;
Clear();


Write("Введите некоторое количество отрицательных и положительных чисел:   ");
int[] array=GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");

WriteLine($"Количество положительных чисел которые ввёл пользователь = {GetPositiveNumbers(array)}.");





int GetPositiveNumbers(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }     
    }
    return count;
}


int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=int.Parse(arS[i]);
    }
  return result;
}