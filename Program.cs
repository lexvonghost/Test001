﻿/* Написать программу, которая, из имеющегося массива строк, формирует массив 
из строк, длина которых меньше либо равна трём символам.*/

string[] input = new string[] {"12343", ":-)", "world", "Russia", "-2"};
string[] output = new string[5];
int outputIndex = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[outputIndex] = input[i];
        outputIndex++;
    }
}