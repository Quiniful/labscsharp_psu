class Tasks
{
    public int sumLastNums(int x)
    {
        return x % 10 + x / 10 % 10;
    }

    public bool isPositive(int x)
    {
        return x > 0;
    }

    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    public bool isDivisor(int a, int b)
    {
        if (a != 0 && b % a == 0)
        {
            return true;
        }
        if (b != 0 && a % b == 0)
        {
            return true;
        }
        return false;
    }

    public int lastNumSum(int a, int b)
    {
        return a % 10 + b % 10;
    }

    public double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }
        return (double)x / y;
    }

    public string makeDecision(int x, int y)
    {
        if (x < y)
        {
            return $"{x} < {y}";
        }
        if (x > y)
        {
            return $"{x} > {y}";
        }
        return $"{x} == {y}";
    }

    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y || y + z == x;
    }

    public string age(int x)
    {
        int lastTwo = x % 100;
        int lastOne = x % 10;

        if (lastTwo >= 11 && lastTwo <= 14)
        {
            return $"{x} лет";
        }
        if (lastOne == 1)
        {
            return $"{x} год";
        }
        if (lastOne >= 2 && lastOne <= 4)
        {
            return $"{x} года";
        }
        return $"{x} лет";
    }

    public void printDays(string x)
    {
        int firstDay = 0;
        switch (x)
        {
            case "понедельник":
                firstDay = 1;
                break;
            case "вторник":
                firstDay = 2;
                break;
            case "среда":
                firstDay = 3;
                break;
            case "четверг":
                firstDay = 4;
                break;
            case "пятница":
                firstDay = 5;
                break;
            case "суббота":
                firstDay = 6;
                break;
            case "воскресенье":
                firstDay = 7;
                break;
            default:
                Console.WriteLine("это не день недели");
                return;
        }

        int i = 0;
        for (i = firstDay; i <= 7; i++)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
                case 7:
                    Console.WriteLine("воскресенье");
                    break;
            }
        }
    }

    public string reverseListNums(int x)
    {
        string result = "";
        int i = 0;
        for (i = x; i >= 0; i--)
        {
            if (i < x)
            {
                result += " ";
            }
            result += i;
        }
        return result;
    }

    public int pow(int x, int y)
    {
        int result = 1;
        int i = 0;
        for (i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    public bool equalNum(int x)
    {
        int lastDigit = x % 10;
        while (x != 0)
        {
            if (x % 10 != lastDigit)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }

    public void leftTriangle(int x)
    {
        int row = 0;
        int column = 0;
        for (row = 1; row <= x; row++)
        {
            for (column = 1; column <= row; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void guessGame()
    {
        Random random = new Random();
        int hidden = random.Next(0, 10);
        int attempts = 0;
        string input = "";
        int answer = 0;

        while (true)
        {
            Console.Write("Введите число от 0 до 9: ");
            input = Console.ReadLine();
            if (!int.TryParse(input, out answer)
                || answer < 0 || answer > 9)
            {
                Console.WriteLine(
                    "Введите целое число от 0 до 9.");
                continue;
            }
            attempts++;
            if (answer == hidden)
            {
                Console.WriteLine("Вы угадали!");
                Console.Write("Количество попыток: ");
                Console.WriteLine(attempts);
                return;
            }
            Console.WriteLine("Вы не угадали.");
        }
    }

    public int findLast(int[] arr, int x)
    {
        int i = 0;
        for (i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] result = new int[arr.Length + 1];
        int i = 0;
        for (i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }
        result[pos] = x;
        for (i = pos; i < arr.Length; i++)
        {
            result[i + 1] = arr[i];
        }
        return result;
    }

    public void reverse(int[] arr)
    {
        int i = 0;
        int other = 0;
        int temp = 0;
        for (i = 0; i < arr.Length / 2; i++)
        {
            other = arr.Length - 1 - i;
            temp = arr[i];
            arr[i] = arr[other];
            arr[other] = temp;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int i = 0;
        for (i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i];
        }
        for (i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }
        return result;
    }

    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        int i = 0;
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        return result;
    }
}
