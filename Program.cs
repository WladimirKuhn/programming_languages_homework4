// Задача 1

bool EvenSumDigits(int number)
{
    bool even = false;
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    if (sum % 2 == 0)
    {
        even = true;
    }
    return even;
}


while (true)
{
    Console.WriteLine("Введите текст: ");
    string text = Console.ReadLine();
    int number = Convert.ToInt32(text);
    bool res = EvenSumDigits(number);
    if (res == true || text == "q")
    {
        break;
    }
}

//Задача 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    
    return array;
}

int GetCountEvenNumbers (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
             count = count + 1;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] resultingArray = CreateArray(sizeArray);
Console.WriteLine($"Ваш массив: [ {string.Join("; ", resultingArray)} ]");
int resultingCount = GetCountEvenNumbers(resultingArray);
Console.WriteLine($"Количество четных чисел в вашем массиве = {resultingCount}");


//Задача 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    
    return array;
}

int[] FlippingArray(int[] mas)
{
    int temporaryVar = 0;
    for (int i = 0, j = mas.Length - 1; i < mas.Length / 2; i++, j = j -1)
    {
        temporaryVar = mas[i];
        mas[i] = mas[j];
        mas[j] = temporaryVar;
    }
    return mas;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] resultingArray = CreateArray(sizeArray);
Console.WriteLine($"Ваш массив: [ {string.Join("; ", resultingArray)} ]");
int[] newArray = FlippingArray(resultingArray);
Console.WriteLine($"Перевернутый массив: [ {string.Join("; ", newArray)} ]");


