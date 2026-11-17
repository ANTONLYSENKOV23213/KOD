//// Задание 1. Конвертер температуры
//Console.Write("Введите температуру в Цельсиях: ");
//double c = Convert.ToDouble(Console.ReadLine());

//double f = c * 9 / 5 + 32;

//Console.WriteLine($"Температура в Фаренгейтах: {f}");


//// Задание 2. Среднее арифметическое
//Console.Write("Введите первое число: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите второе число: ");
//double b = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите третье число: ");
//double d = Convert.ToDouble(Console.ReadLine());

//double average = (a + b + d) / 3;

//Console.WriteLine($"Среднее арифметическое: {average}");


//// Задание 3. Калькулятор
//Console.Write("Введите первое число: ");
//double x = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введите второе число: ");
//double y = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Сумма: {x + y}");
//Console.WriteLine($"Разность: {x - y}");
//Console.WriteLine($"Произведение: {x * y}");

//if (y != 0)
//    Console.WriteLine($"Частное: {x / y}");
//else
//    Console.WriteLine("На ноль делить нельзя.");




////Дз номер 4


//using System;

//// Задание 1. Калькулятор оценок

//int[] grades = { 5, 4, 3, 5, 2, 5, 4 };

//int sum = 0;
//int fives = 0;
//int twos = 0;

//foreach (int grade in grades)
//{
//    sum += grade;

//    if (grade == 5)
//        fives++;

//    if (grade == 2)
//        twos++;
//}

//double average = (double)sum / grades.Length;

//Console.WriteLine("Средний балл: " + average);
//Console.WriteLine("Количество пятёрок: " + fives);
//Console.WriteLine("Количество двоек: " + twos);


//// Задание 2. Переворот массива

//int[] numbers = { 1, 2, 3, 4, 5 };

//Console.WriteLine("\nПрямой порядок:");

//foreach (int number in numbers)
//{
//    Console.Write(number + " ");
//}

//Console.WriteLine("\nОбратный порядок:");

//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write(numbers[i] + " ");
//}

//Console.WriteLine();


//// Задание 3. Вывод чётных чисел

//Console.WriteLine("\nЧётные числа от 1 до 20:");

//for (int i = 1; i <= 20; i++)
//{
//    if (i % 2 != 0)
//        continue;

//    Console.Write(i + " ");
//}

//Console.WriteLine();


//// Задание 4. Ввод пароля

//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Введите пароль: ");
//    string password = Console.ReadLine() ?? "";

//    if (password == "1234")
//    {
//        Console.WriteLine("Доступ разрешён");
//        break;
//    }

//    if (i == 3)
//        Console.WriteLine("Доступ запрещён");
//    else
//        Console.WriteLine("Неверный пароль. Попробуйте ещё раз.");
//}






//КЛАССНАЯ ЗА 17.11.26



//1 задание
//void SayHello()
//{
//    Console.WriteLine("Привет, мир!");
//}

//SayHello();
//SayHello();
//SayHello();


//2 задание 
void Greet(string name)
{
    Console.WriteLine("Привет," + name + "!");
}
Greet("Саша");
Greet("Ярослав");
Greet("Анна");

//3 задание 
void PrintPerson(string name, int age, string city)
{
    Console.WriteLine("Имя: " + name + " Возраст: " + age + " Город: " + city);
}

PrintPerson("Егор", 15, "Москва");
PrintPerson("Мария", 22, "Санкт-Петербург");

// 4 задание
void PrintPerson(string name, int age = 18, string hobby = "Не указано")
{
    Console.WriteLine("Имя: " + name + ", Возраст: " + age + ", Хобби: " + hobby);
}

PrintPerson("Иван");
PrintPerson("Ольга", 25, "Рисование");

//5 задание
int Square(int x)
{
    return x * x;
}

int result = Square(5);
Console.WriteLine("Квадрат числа 5 равен: " + result);