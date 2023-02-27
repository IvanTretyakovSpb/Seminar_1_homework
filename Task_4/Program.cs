// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение
// Запрашиваем у пользователя три числа для последующего сравнения

Console.Write("Введите первое целое число для сравнения: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите, пожалуйста, второе целое число для сравнения: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите последнее, третье целое число: ");
int userNumber3 = int.Parse(Console.ReadLine() ?? "");

// Производим сравнение введенных пользователем чисел и запоминаем максимальное число

int max = userNumber1;

if(userNumber2 > userNumber1 && userNumber2 >= userNumber3)
{
    max = userNumber2;
}
else if(userNumber3 > userNumber1 && userNumber3 > userNumber2)
{
    max = userNumber3;
}

// убираем всё лишнее из экрана терминала и выводим полученный результат

Console.Clear();
Console.WriteLine($"Максимальное число {max}");