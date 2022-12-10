/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число! - ");
string num1_str = Console.ReadLine()??"";
int num1 = Convert.ToInt32(num1_str);

Console.Write("Введите второе число! - ");
string num2_str = Console.ReadLine()??"";
int num2 = Convert.ToInt32(num2_str);

Console.Write("Введите третье число! - ");
string num3_str = Console.ReadLine()??"";
int num3 = Convert.ToInt32(num3_str);

int max1 = num1;

if (max1 < num2)
{
    max1 = num2;
}

if (max1 < num3)
{
    max1 = num3;
}

Console.WriteLine($"Максимальное число равняеться - {max1}");
