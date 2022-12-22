// Напишите программу, которая принимает на вход два числа (A и B) 
// и метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//  Не использовать Math.Pow()



int numberA = ReadInt("Input number A: ");
int numberB = ReadInt("Input number B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}




// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

int number = ReadInt("Input number: ");
int length = NumberLength(number);
SumNumbers(number, length);


// Функция ввода

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}


// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lengthArray = ReadInt("Input array length: ");

int[] randomArray = new int[lengthArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}