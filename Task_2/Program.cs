/*Задача 2: Напишите программу, которая на вход принимает
два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите первое число! - ");
string num_str1 = Console.ReadLine()??"";
int num1 = Convert.ToInt32(num_str1);

Console.Write("Введите второе число! - ");
string num_str2 = Console.ReadLine()??"";
int num2 = Convert.ToInt32(num_str2);

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} большее, а число {num2} меньшее");
}
if (num1 < num2)
{
    Console.WriteLine($"Число {num2} большее, а число {num1} меньшее");
}
if (num1 == num2)
{
    Console.WriteLine("Вы ввели два одинаковых числа");
}