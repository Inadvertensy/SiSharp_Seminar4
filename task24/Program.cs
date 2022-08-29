// Задача 24: Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("insert number");

int num=int.Parse(Console.ReadLine());
int result=1;
for (int i=1;i<num;i++)
{
 result=result+i;
 result++;
}
Console.WriteLine(result);

// Console.WriteLine("Insert number");

// int num=Convert.ToInt32(Console.ReadLine());
// int b=1;
// for (int a=1; a<=num; a++)
// {
//     b=b*a;
// }
// Console.WriteLine("Factorial "+b);