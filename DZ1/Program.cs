Console.WriteLine("Введите два числа");
/*
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
var Number1 = int.Parse(number1);
var Number2 = int.Parse(number2); 
*/
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Первое число больше");
}
else if (Number1 < Number2)
{
    Console.WriteLine("Второе число больше");
}
else
{
    Console.WriteLine("Числа равны");
}
