﻿//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите последовательность чисел");
string num = Console.ReadLine();

int countPlus = 0;

string[] arrNums = num.Split(',');
for (int i = 0; i < arrNums.Length; i++)
{
    double element = double.Parse(arrNums[i]);
    if (element > 0)  
        countPlus +=1;
      
}

//int length = num.Length;
//int countMinus = 0;
//int countSpace = 0;
//for (int i = 0; i < length; i++)
//{
 //   if (num[i] == '-')  
  //      countMinus +=1;

  //  if (num[i] == ' ')  
  //      countSpace +=1;
    
Console.WriteLine($"Число положительных элементов равно {countPlus}");
