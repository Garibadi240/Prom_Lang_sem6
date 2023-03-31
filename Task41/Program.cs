Console.Clear();

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int number = GetNumberFromUser("Введите количество чисел: ", "Ошибка ввода!");

int[] array = GetArray(number);

Console.WriteLine(String.Join(" ", array));

int count =  NumbersGreaterZero(array);

Console.WriteLine($"Вы ввели чисел больше 0: {count}");



int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
    }
    return res;
}

int NumbersGreaterZero(int[] arr){
    int count = 0;
    foreach (var el in arr)
    {
        if (el > 0) count ++;
    }
    return count;
}