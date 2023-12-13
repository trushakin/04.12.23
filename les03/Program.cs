
Console.WriteLine("Введите число 1"); 
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2"); 
int num2=Convert.ToInt32(Console.ReadLine());

if(num1 % num2==0) // если остаток от деления между числоми равен 0
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет," + num1%num2); 
}