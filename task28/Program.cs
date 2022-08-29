// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Insert number");

int num=Convert.ToInt32(Console.ReadLine());
int b=1;
for (int a=1; a<=num; a++)
{
    b=b*a;
}
Console.WriteLine("Factorial "+b);