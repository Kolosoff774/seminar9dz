/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите натуральное число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > 0 && number2 > 0) 
{
    Console.WriteLine(SumNaturalNumbers(number1, number2));
} else Console.Write("Введите положительное натуральное число!");


int SumNaturalNumbers(int num1, int num2) 
{
    int sum = 1;
    if (num1 < num2) 
    {
        sum = num1 + SumNaturalNumbers(num1 + 1, num2);
    }
    else if(num1 > num2) 
    {
        sum = num2 + SumNaturalNumbers(num1, num2 + 1);
    }
    else sum = num1;
    return sum;
}