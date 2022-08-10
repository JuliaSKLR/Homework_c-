//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}


int N = Prompt("Введите число ");
for(int i=0; i<=N; i=i+2)
{
    Console.Write(i);
    Console.Write(",");
}