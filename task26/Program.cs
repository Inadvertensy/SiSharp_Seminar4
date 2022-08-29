// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.WriteLine("Insert number");
int A=Convert.ToInt32(Console.ReadLine());
double res=Math.Log10(A)+1;
//res=Math.Round(res,0);
Console.WriteLine(res);

int count=0;
while(A>0)
{
    A/=10;
    count++;
}
Console.WriteLine(count);