// Вводим цифру, обозначающую день недели, и проверяем, является ли этот день выходным
Console.WriteLine ("Введите день недели цифрой:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7) Console.WriteLine ("Да, это выходной!");
    else Console.WriteLine ("Неа, не выходной!");
}
else Console.WriteLine ("Введите значение от 1 до 7");