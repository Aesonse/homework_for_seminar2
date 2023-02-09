// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.Write("Третьей цифры нет.");
    return;
}
int result = (num / 100) % 10;
Console.WriteLine($"Третья цифра {result}");