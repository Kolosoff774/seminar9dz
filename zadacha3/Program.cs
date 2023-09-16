/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введи неотрицательное число m: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введи неотрицательное число n: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 >= 0 && number2 >= 0) 
{
    Console.WriteLine(Ack(number1, number2));
} else Console.Write("Введите положительное число!");

int Ack(int m, int n) 
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}