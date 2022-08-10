//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> Четное

int Prompt(string message)
{
System.Console.Write(message);              // Вывести сообщение
string readValue = Console.ReadLine();      // Считавает с консоли строку
int result = int.Parse(readValue);          // Преобразует строку в целое число
return result;                              // Возвращает результат
}

int N = Prompt("Введите число ");
if (N%2 > 0)
    {
        Console.WriteLine("Число N не четное");
    }
else 
{
    Console.WriteLine("Число N четное");
}

