Lab1 lab = new Lab1();
lab.Run();

class Lab1
{
    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("1 - Сумма двух последних цифр");
            Console.WriteLine(
                "2 - Проверка положительного числа");
            Console.WriteLine("3 - Заглавная латинская буква");
            Console.WriteLine("4 - Делимость двух чисел");
            Console.WriteLine(
                "5 - Сумма последних цифр пяти чисел");
            Console.WriteLine("6 - Деление с проверкой нуля");
            Console.WriteLine("7 - Сравнение двух чисел");
            Console.WriteLine("8 - Сумма двух из трёх чисел");
            Console.WriteLine("9 - Возраст");
            Console.WriteLine("10 - Дни недели");
            Console.WriteLine("11 - Числа от заданного до нуля");
            Console.WriteLine("12 - Возведение в степень");
            Console.WriteLine("13 - Одинаковые цифры");
            Console.WriteLine("14 - Треугольник из звёздочек");
            Console.WriteLine("15 - Угадывание числа");
            Console.WriteLine(
                "16 - Последнее вхождение в массив");
            Console.WriteLine("17 - Вставка в массив");
            Console.WriteLine("18 - Разворот массива");
            Console.WriteLine("19 - Объединение массивов");
            Console.WriteLine(
                "20 - Удаление отрицательных чисел");
            Console.WriteLine("0 - Выход");

            int task = ReadInt(
                "Выберите задачу от 1 до 20: ",
                0,
                20);
            if (task == 0)
            {
                return;
            }

            switch (task)
            {
                case 1:
                    {
                        int number = ReadInt(
                            "Введите число не меньше 10: ",
                            10,
                            int.MaxValue);
                        Console.Write("Сумма последних цифр: ");
                        Console.WriteLine(
                            new Task1().sumLastNums(number));
                        break;
                    }
                case 2:
                    {
                        int number = ReadInt("Введите число: ");
                        Console.Write("Положительное: ");
                        Console.WriteLine(
                            new Task2().isPositive(number));
                        break;
                    }
                case 3:
                    {
                        char letter = ReadChar(
                            "Введите один символ: ");
                        Console.Write(
                            "Большая латинская буква: ");
                        Console.WriteLine(
                            new Task3().isUpperCase(letter));
                        break;
                    }
                case 4:
                    {
                        int first = ReadInt(
                            "Введите первое число: ");
                        int second = ReadInt(
                            "Введите второе число: ");
                        Console.Write(
                            "Одно число делит другое: ");
                        Console.WriteLine(
                            new Task4().isDivisor(
                                first,
                                second));
                        break;
                    }
                case 5:
                    {
                        Task5 task5 = new Task5();
                        int result = ReadInt(
                            "Число 1: ",
                            0,
                            int.MaxValue);
                        for (int i = 2; i <= 5; i++)
                        {
                            int next = ReadInt(
                                $"Число {i}: ",
                                0,
                                int.MaxValue);
                            result = task5.lastNumSum(
                                result,
                                next);
                            Console.Write(
                                "Промежуточный результат: ");
                            Console.WriteLine(result);
                        }
                        Console.WriteLine($"Итого: {result}");
                        break;
                    }
                case 6:
                    {
                        int first = ReadInt("Введите делимое: ");
                        int second = ReadInt(
                            "Введите делитель: ");
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            new Task6().safeDiv(first, second));
                        break;
                    }
                case 7:
                    {
                        int first = ReadInt(
                            "Введите первое число: ");
                        int second = ReadInt(
                            "Введите второе число: ");
                        Console.WriteLine(
                            new Task7().makeDecision(
                                first,
                                second));
                        break;
                    }
                case 8:
                    {
                        int first = ReadInt(
                            "Введите первое число: ");
                        int second = ReadInt(
                            "Введите второе число: ");
                        int third = ReadInt(
                            "Введите третье число: ");
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            new Task8().sum3(
                                first,
                                second,
                                third));
                        break;
                    }
                case 9:
                    {
                        int years = ReadInt(
                            "Введите возраст: ",
                            0,
                            int.MaxValue);
                        Console.WriteLine(
                            new Task9().age(years));
                        break;
                    }
                case 10:
                    {
                        Console.Write("Введите день недели: ");
                        string dayName = Console.ReadLine();
                        if (dayName == null)
                        {
                            dayName = "";
                        }
                        new Task10().printDays(dayName);
                        break;
                    }
                case 11:
                    {
                        int number = ReadInt(
                            "Введите число от 0 до 1000: ",
                            0,
                            1000);
                        Console.WriteLine(
                            new Task11().reverseListNums(
                                number));
                        break;
                    }
                case 12:
                    {
                        int basis = ReadInt(
                            "Введите основание: ");
                        int exponent = ReadInt(
                            "Введите степень от 0 до 100: ",
                            0,
                            100);
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            new Task12().pow(basis, exponent));
                        break;
                    }
                case 13:
                    {
                        int number = ReadInt(
                            "Введите целое число: ");
                        Console.Write("Все цифры одинаковые: ");
                        Console.WriteLine(
                            new Task13().equalNum(number));
                        break;
                    }
                case 14:
                    {
                        int height = ReadInt(
                            "Введите высоту от 0 до 100: ",
                            0,
                            100);
                        new Task14().leftTriangle(height);
                        break;
                    }
                case 15:
                    {
                        new Task15().guessGame();
                        break;
                    }
                case 16:
                    {
                        int[] numbers = ReadArray();
                        int value = ReadInt("Что найти: ");
                        Console.Write("Последний индекс: ");
                        Console.WriteLine(
                            new Task16().findLast(
                                numbers,
                                value));
                        break;
                    }
                case 17:
                    {
                        int[] numbers = ReadArray();
                        int item = ReadInt(
                            "Какое число вставить: ");
                        int position = ReadInt(
                            "В какую позицию: ",
                            0,
                            numbers.Length);
                        PrintArray(
                            new Task17().add(
                                numbers,
                                item,
                                position));
                        break;
                    }
                case 18:
                    {
                        int[] numbers = ReadArray();
                        new Task18().reverse(numbers);
                        PrintArray(numbers);
                        break;
                    }
                case 19:
                    {
                        int[] numbers = ReadArray();
                        Console.WriteLine(
                            "Введите второй массив.");
                        int[] second = ReadArray();
                        PrintArray(
                            new Task19().concat(
                                numbers,
                                second));
                        break;
                    }
                case 20:
                    {
                        int[] numbers = ReadArray();
                        PrintArray(
                            new Task20().deleteNegative(
                                numbers));
                        break;
                    }
            }
        }
    }

    private int ReadInt(string message)
    {
        return ReadInt(message, int.MinValue, int.MaxValue);
    }

    private int ReadInt(string message, int minimum, int maximum)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number)
                && number >= minimum
                && number <= maximum)
            {
                return number;
            }
            Console.WriteLine(
                "Введите целое число в допустимом диапазоне.");
        }
    }

    private char ReadChar(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (input != null && input.Length == 1)
            {
                return input[0];
            }
            Console.WriteLine("Введите один символ.");
        }
    }

    private int[] ReadArray()
    {
        int length = ReadInt(
            "Сколько элементов в массиве (от 0 до 100): ",
            0,
            100);
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = ReadInt($"Элемент {i}: ");
        }
        return result;
    }

    private void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }
            Console.Write(arr[i]);
        }
        Console.WriteLine("]");
    }
}
