Console.Clear();

/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

int number = 2;
int number1 = 0;
int number2 = 1;

Console.WriteLine("Введите коэффициенты a1 и b1 линейной функции y=f(x):");
double[] array1 = GetArray(number);

Console.WriteLine("Введите коэффициенты a2 и b2 линейной функции y=g(x):");
double[] array2 = GetArray(number);

double[] arr = FindingIntersectionPoint(array1, array2);

Console.WriteLine($"Точка пересечения: ({arr[0]}, {arr[1]})");



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


double[] GetArray(int size){
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = GetNumberFromUser("Вы ввели чисело: ", "Ошибка ввода!");
    }
    return res;
}

double[] FindingIntersectionPoint(double[] arr1, double[] arr2){
    double pointX = (arr2[number2]-arr1[number2])/(arr1[number1]-arr2[number1]);
    double pointY = arr1[number1]*pointX+arr1[number2];
    
    double[] arr = new double[] {pointX, pointY};

    return arr;
}
