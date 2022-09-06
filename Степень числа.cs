int i, j;

//Проверка ввода
int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

//Код программы
Console.Write("Введи целое число:");
i = CorrectInput();

Console.Write("Введи целое число, степень возведения:");
j = CorrectInput();

Console.Write($"Результат возведения в степень = {Math.Pow(i,j)}");