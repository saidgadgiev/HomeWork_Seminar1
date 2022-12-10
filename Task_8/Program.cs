/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите любое положительное число! - ");
string num1_str = Console.ReadLine()??"";
int num1 = Convert.ToInt32(num1_str);

for (int i = 2; i <= num1; i=i+2)
{
    Console.Write(i + " ");
}