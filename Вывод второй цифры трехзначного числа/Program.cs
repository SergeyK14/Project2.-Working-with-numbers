// Вывод второй цифры трехзначного числа
void Zadacha10()
{
Console.WriteLine ("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 != 0)
{
    number = number%100;
    number = number - number%10;
    number = number/10;
    Console.WriteLine(number);
}
else Console.WriteLine ("Число не является трехзначным, введите другое число");
}

Zadacha10();