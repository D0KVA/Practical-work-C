using System;
double a = 0.0;
int c;
double zxc, solo;
do
{
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычетание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возвести в степень");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Найти факториал");
    Console.WriteLine("9. Выход");
    Console.Write("Введите номер операции:");
    if (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Вы ввели буквы или слово, а не номер операции");
        continue;
    }
    switch (c)
    {
        case 1:
            Console.Write("Введите первое число: ");
            zxc = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            solo = double.Parse(Console.ReadLine());
            a = zxc + solo;
            Console.WriteLine($"Результат: {a}");
            break;
        case 2:
            Console.Write("Введите первое число: ");
            zxc = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            solo = double.Parse(Console.ReadLine());
            a = zxc - solo;
            Console.WriteLine($"Результат: {a}");
            break;
        case 3:
            Console.Write("Введите первое число: ");
            zxc = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            solo = double.Parse(Console.ReadLine());
            a = zxc * solo;
            Console.WriteLine($"Результат: {a}");
            break;
        case 4:
            Console.Write("Введите первое число: ");
            zxc = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            solo = double.Parse(Console.ReadLine());
            if (solo != 0)
            {
                a = zxc / solo;
                Console.WriteLine($"Результат: {a}");
            }
            else
            {
                Console.WriteLine("Фатальная ошибка.");
            }
            break;
        case 5:
            Console.Write("Введите число: ");
            zxc = double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int power = int.Parse(Console.ReadLine());
            a = Math.Pow(zxc, power);
            Console.WriteLine($"Результат: {a}");
            break;
        case 6:
            Console.Write("Введите число: ");
            zxc = double.Parse(Console.ReadLine());
            a = Math.Sqrt(zxc);
            Console.WriteLine($"Результат: {a}");
            break;
        case 7:
            Console.Write("Введите число: ");
            zxc = double.Parse(Console.ReadLine());
            a = zxc / 100;
            Console.WriteLine($"1% числа: {a}");
            break;
        case 8:
            double CalculateFactorial(double number)
            {
                double fl = 1;
                for (int i = 1; i <= number; i++)
                {
                    fl *= i;
                }
                return fl;
            }
            Console.Write("Введите число: ");
            zxc = double.Parse(Console.ReadLine());
            a = CalculateFactorial(zxc);
            Console.WriteLine($"Факториал {zxc} = {a}");
            break;
        case 9:
            Console.WriteLine("Стоп.");
            break;
        default:
            Console.WriteLine("Попробуй еще раз.");
            break;
    }
} while (c != 9);
