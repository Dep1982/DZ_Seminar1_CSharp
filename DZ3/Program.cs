Console.WriteLine("Введите число");
/*
string number1 = Console.ReadLine();
var Number1 = int.Parse(number1);
*/
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} четное число");
}
else
{
    Console.WriteLine($"{number} не четное число");
}
