/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите число для проверки, являеться ли это число четным");
Console.Write("Введите число! - ");
string num_str = Console.ReadLine();
int num = Convert.ToInt32(num_str);

int resultat = num % 2;

if (resultat == 0)
{ 
    Console.WriteLine($"{num} -> да");
}
else
{ 
    Console.WriteLine($"{num} -> нет");
}

