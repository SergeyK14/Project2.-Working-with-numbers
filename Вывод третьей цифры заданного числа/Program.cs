// Вывод второй цифры заданного числа или сообщение об ошибке
void Zadacha13()
{
Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 != 0)
{
    number = number%100;
    number = number%10;
    Console.WriteLine(number);
}
else Console.WriteLine ("Третьей цифры нет");
}

Zadacha13();
