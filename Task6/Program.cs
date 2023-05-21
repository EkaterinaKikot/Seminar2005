Console.Clear();
Console.Write("Введите 1 число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0)
Console.WriteLine("Да. Чётное");
else
Console.WriteLine("Нет. Нечётное");


