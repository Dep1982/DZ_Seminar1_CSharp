Console.WriteLine("Введите три числа");
/*
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
string number3 = Console.ReadLine();
var Number1 = int.Parse(number1);
var Number2 = int.Parse(number2);
var Number3 = int.Parse(number3);
*/
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
int Number3 = int.Parse(Console.ReadLine());
int max = Number1;

if (max < Number2)
{
    max = Number2;
}
if (max < Number3)
{
    max = Number3;
}
Console.WriteLine($"{max} это максимальное число");
