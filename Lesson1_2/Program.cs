//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int value1 = Prompt("Введите число A ");
int value2 = Prompt("Введите число B ");
int value3 = Prompt("Введите число C ");
if (value1 > value2) 
{ 
    if (value1 > value3) 
    {
        Console.WriteLine ("Наибольшее Число - A ");
    }
}
else if (value2 > value3) 
    {
    Console.WriteLine ("Наибольшее Число - B ");
    }

else 
{
    Console.WriteLine ("Наибольшее Число - C ");
}