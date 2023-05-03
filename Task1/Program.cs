// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
string numberback;
if (Convert.ToInt32(number)<100000 && Convert.ToInt32(number)>9999)
{
    char[] back = number.ToCharArray();
    Array.Reverse(back);
   numberback= new string(back); 
Console.WriteLine(numberback);
if (number == numberback) Console.WriteLine("да");

else Console.WriteLine("нет");
}
else Console.WriteLine("Число не является пятизначным, попробуй снова");
