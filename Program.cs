Lab1 lab = new Lab1();
lab.Run();

class Lab1
{
    public void Run()
    {
        int task = 0;
        int number = 0;
        char letter = '\0';
        int first = 0;
        int second = 0;
        Tasks tasks = new Tasks();
        int result = 0;
        int i = 0;
        int next = 0;
        int third = 0;
        int years = 0;
        string dayName = "";
        int basis = 0;
        int exponent = 0;
        int height = 0;
        int[] numbers = new int[0];
        int value = 0;
        int item = 0;
        int position = 0;
        int[] secondArray = new int[0];

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

            task = ReadInt(
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
                        number = ReadInt(
                            "Введите число не меньше 10: ",
                            10,
                            int.MaxValue);
                        Console.Write("Сумма последних цифр: ");
                        Console.WriteLine(
                            tasks.sumLastNums(number));
                        break;
                    }
                case 2:
                    {
                        number = ReadInt("Введите число: ");
                        Console.Write("Положительное: ");
                        Console.WriteLine(
                            tasks.isPositive(number));
                        break;
                    }
                case 3:
                    {
                        letter = ReadChar(
                            "Введите один символ: ");
                        Console.Write(
                            "Большая латинская буква: ");
                        Console.WriteLine(
                            tasks.isUpperCase(letter));
                        break;
                    }
                case 4:
                    {
                        first = ReadInt(
                            "Введите первое число: ");
                        second = ReadInt(
                            "Введите второе число: ");
                        Console.Write(
                            "Одно число делит другое: ");
                        Console.WriteLine(
                            tasks.isDivisor(
                                first,
                                second));
                        break;
                    }
                case 5:
                    {
                        result = ReadInt(
                            "Число 1: ",
                            0,
                            int.MaxValue);
                        for (i = 2; i <= 5; i++)
                        {
                            next = ReadInt(
                                $"Число {i}: ",
                                0,
                                int.MaxValue);
                            result = tasks.lastNumSum(
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
                        first = ReadInt("Введите делимое: ");
                        second = ReadInt(
                            "Введите делитель: ");
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            tasks.safeDiv(first, second));
                        break;
                    }
                case 7:
                    {
                        first = ReadInt(
                            "Введите первое число: ");
                        second = ReadInt(
                            "Введите второе число: ");
                        Console.WriteLine(
                            tasks.makeDecision(
                                first,
                                second));
                        break;
                    }
                case 8:
                    {
                        first = ReadInt(
                            "Введите первое число: ");
                        second = ReadInt(
                            "Введите второе число: ");
                        third = ReadInt(
                            "Введите третье число: ");
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            tasks.sum3(
                                first,
                                second,
                                third));
                        break;
                    }
                case 9:
                    {
                        years = ReadInt(
                            "Введите возраст: ",
                            0,
                            int.MaxValue);
                        Console.WriteLine(
                            tasks.age(years));
                        break;
                    }
                case 10:
                    {
                        Console.Write("Введите день недели: ");
                        dayName = Console.ReadLine();
                        if (dayName == null)
                        {
                            dayName = "";
                        }
                        tasks.printDays(dayName);
                        break;
                    }
                case 11:
                    {
                        number = ReadInt(
                            "Введите число от 0 до 1000: ",
                            0,
                            1000);
                        Console.WriteLine(
                            tasks.reverseListNums(
                                number));
                        break;
                    }
                case 12:
                    {
                        basis = ReadInt(
                            "Введите основание: ");
                        exponent = ReadInt(
                            "Введите степень от 0 до 100: ",
                            0,
                            100);
                        Console.Write("Результат: ");
                        Console.WriteLine(
                            tasks.pow(basis, exponent));
                        break;
                    }
                case 13:
                    {
                        number = ReadInt(
                            "Введите целое число: ");
                        Console.Write("Все цифры одинаковые: ");
                        Console.WriteLine(
                            tasks.equalNum(number));
                        break;
                    }
                case 14:
                    {
                        height = ReadInt(
                            "Введите высоту от 0 до 100: ",
                            0,
                            100);
                        tasks.leftTriangle(height);
                        break;
                    }
                case 15:
                    {
                        tasks.guessGame();
                        break;
                    }
                case 16:
                    {
                        numbers = ReadArray();
                        value = ReadInt("Что найти: ");
                        Console.Write("Последний индекс: ");
                        Console.WriteLine(
                            tasks.findLast(
                                numbers,
                                value));
                        break;
                    }
                case 17:
                    {
                        numbers = ReadArray();
                        item = ReadInt(
                            "Какое число вставить: ");
                        position = ReadInt(
                            "В какую позицию: ",
                            0,
                            numbers.Length);
                        PrintArray(
                            tasks.add(
                                numbers,
                                item,
                                position));
                        break;
                    }
                case 18:
                    {
                        numbers = ReadArray();
                        tasks.reverse(numbers);
                        PrintArray(numbers);
                        break;
                    }
                case 19:
                    {
                        numbers = ReadArray();
                        Console.WriteLine(
                            "Введите второй массив.");
                        secondArray = ReadArray();
                        PrintArray(
                            tasks.concat(
                                numbers,
                                secondArray));
                        break;
                    }
                case 20:
                    {
                        numbers = ReadArray();
                        PrintArray(
                            tasks.deleteNegative(
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
        string input = "";
        int number = 0;
        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();
            if (int.TryParse(input, out number)
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
        string input = "";
        while (true)
        {
            Console.Write(message);
            input = Console.ReadLine();
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
        int i = 0;
        for (i = 0; i < length; i++)
        {
            result[i] = ReadInt($"Элемент {i}: ");
        }
        return result;
    }

    private void PrintArray(int[] arr)
    {
        int i = 0;
        Console.Write("[");
        for (i = 0; i < arr.Length; i++)
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
