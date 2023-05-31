Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

while (number.Length != 5)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    number = Console.ReadLine()!;
}

if (number[0] == number[4] || number[1] == number[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");