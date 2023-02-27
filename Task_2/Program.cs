// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение
// Запрашиваем у пользователя первое число для последующего сравнения

Console.Write("Введите первое целое число для сравнения: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

// Запрашиваем у второе число

Console.Write("Введите, пожалуйста, второе целое число для сравнения: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");

// убираем всё лишнее из экрана терминала для более наглядного вывода результата

Console.Clear();

// Производим сравнение введенных пользователем чисел и выводим результат

if(userNumber1 > userNumber2)
{
    Console.WriteLine($"Число {userNumber1} больше числа {userNumber2}.");
}
else if(userNumber1 < userNumber2)
{
    Console.WriteLine($"Число {userNumber2} больше числа {userNumber1}.");
}
else
{
    Console.WriteLine($"Введенные числа {userNumber1} и {userNumber2} равны.");
}


