//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число = ");
int A = int.Parse(Console.ReadLine()!);
int B = 1;
while (B <= A)
{
    if (B == A)
    {
        Console.Write(B * B * B + ". ");
    }
    else
    {
        Console.Write(B * B * B + ", ");
    }
    B++;
}
