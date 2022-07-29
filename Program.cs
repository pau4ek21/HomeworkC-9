//Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
//N = 4532 -> 4
/*

int NumbersCount(int N)
{
    if (N / 10 != 0)
        return 1 + NumbersCount(N / 10);

    else return 1;
}

Console.Write("Пожалуйста, введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Количетсво цифр в указанном числе: " + NumbersCount(n1));
*/



//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfElements(int M, int N)
{
    if (M < N)
    {
        while (M != N)
            return M + SumOfElements(M + 1, N);
    }

    if (M > N)
    {
        while (M != N)
            return M + SumOfElements(M - 1, N);
    }

    return M;
}

Console.Write("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных элементов в указанном промежутке: " + SumOfElements(m, n));