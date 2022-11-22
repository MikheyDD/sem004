// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число ");
var num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetMultiply(num));
int GetMultiply(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}