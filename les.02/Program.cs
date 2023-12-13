//  напишите программу, которая принимает на вход трехзначное 
// число и возводит вторую цифру этого числа в степень,
//равную третьей цифре.
// Примеры 
// 487=> 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите число"); 
int num=Convert.ToInt32(Console.ReadLine());


if(num>99 && num<1000) 
{
int num2=num/10 %10;  // чисо/10 и остаток от 10
int num3= num%10; 
int result =1;

while(num3>=1)
{
    result= result *num2;
    num3--; // num3=num3-1;
}
    Console.WriteLine(result);


}
else
{
    Console.WriteLine("не верное число!");
}