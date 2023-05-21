Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
Console.WriteLine("Первое число больше второго. Второе число меньше первого");
else if (n < m)
Console.WriteLine("Второе число больше первого. Первое число меньше второго");
else
Console.WriteLine("Числа равны");
