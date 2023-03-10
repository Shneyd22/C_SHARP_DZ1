Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());  
if (num1 > num2)
{
    Console.WriteLine("Максимальное число " + num1);
    Console.WriteLine("Минимальное число " + num2);
}
if (num1 < num2)
{
    Console.WriteLine("Максимальное число " + num2);
    Console.WriteLine("Минимальное число " + num1);
}
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}   