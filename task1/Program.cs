//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число ");
int A = int.Parse(Console.ReadLine()!);
int B = A % 10; // последняя цифра числа
int C = A / 10000; // первая цифра числа
int D = A / 1000 % 10; // вторая цифра числа
int E = A % 100 / 10; // четвертая цифра числа
if (B == C & D == E)
{
    Console.WriteLine("Число является полиморфом ");
}
else
{
    Console.WriteLine("Число не является полиморфом ");
}