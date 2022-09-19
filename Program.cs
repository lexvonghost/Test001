/* Написать программу, которая, из имеющегося массива строк, формирует массив 
из строк, длина которых меньше либо равна трём символам.*/

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
string[] input = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите строку:");
    string? test = Console.ReadLine();
    if(test != null)
    {
        input[i] = test;
    }
    else
    {
       input[i] = "";
    }
}

string[] output = new string[n];
int outputIndex = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[outputIndex] = input[i];
        outputIndex++;
    }
}

Console.WriteLine("Строки, длина которых меньше трёх:");
Console.Write("[");
for (int i = 0; i < outputIndex; i++)
{
    Console.Write("'" + output[i] + "'");
    if ( i <  outputIndex - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");