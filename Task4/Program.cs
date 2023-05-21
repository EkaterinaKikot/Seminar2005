Console.Clear();
Console.WriteLine("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine()!);
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine("Максимальное из этих чисел ="+ max);

