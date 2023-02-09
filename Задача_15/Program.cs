// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int weekDayNumber = int.Parse(Console.ReadLine());
if (weekDayNumber == 6 || weekDayNumber == 7)
{
    Console.Write("Этот день выходной");
}
else if (weekDayNumber < 6 && weekDayNumber > 0)
{
    Console.Write("Будний день");
}
else
{
    Console.Write("Такого дня недели нет");
}