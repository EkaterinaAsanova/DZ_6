Console.WriteLine("Выберите задание: ");
Console.WriteLine("Задание 41. Подсчет чисел больше 0 ");
Console.WriteLine("Задание 43. Точка пересечения 2х прямых");
int n = Convert.ToInt32(Console.ReadLine());

switch (n){
    case 41: Task41();
    break;
    case 43: Task43();
    break;
    default:
    break;
}

void Task41()
{
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива: ");
int LengthArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите {0} чисел в строку", LengthArray);
int[] array = new int [LengthArray];
string[] input = Console.ReadLine().Split(' ', ',');
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(input[i]);
int Poisk(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("Чисел больше 0 равно: " + Poisk(array));
}

void Task43()
{
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение переменных для уравнения y = k1 * x + b1 ");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите значение переменных для уравнения y = k2 * x + b2 ");
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine (Tochka(b1, b2, k1, k2));
string Tochka (double b1, double b2, double k1, double k2)
{
double x = 0;
double y = 0;
string text = ""; 
if (k1 != k2) 
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    text = $"Прямые пересекуются в точке x = {x}, y = {y}"; 
}
if ((k1==k2) && (b1==b2)) 
{
    text = "Прямые совпадают";
}
if ((k1==k2) && (b1!=b2))
{
    text ="Прямые параллельны";
}
return text;
}
}