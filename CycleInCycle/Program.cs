// string Method4(int count, string text) // переписываем метод4 для цикла "for" 
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
//Console.WriteLine(res);

// Cycle In cycle - вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); // интерполяция строк
    }
    Console.WriteLine();
}