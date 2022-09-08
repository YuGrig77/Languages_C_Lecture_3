// *Methods Types:
// *Type1
void Method1() // method name without argument, No input and no output(return)
{
    Console.WriteLine("Author ..."); // Some info which will be called on request
}
//Method1(); // Method's call (brackets compulsory!). It ill give
//*us required infor "Author ...".

//*Type2

void Method2(string msg) // May content some arguments
{
    Console.WriteLine(msg);
}
//Method2(msg: "Tekst of msg"); // may be called not named 
// *named (using "msg:") if there are more than one argument
// *for example

void Method21 (string msg, int count) // принимает, но не возвращает
{
    int i = 0; // значение переменной count, чтобы показывать определенное кол-во переменной msg
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // !increment! increasing of "i" on 1
    }
}
//Method21(msg: "Text", count: 4); // может вызываться и не именной ("Text", 4), если 
// *используются именные переменные, то можно не соблюдать последовательность, например:
//Console.WriteLine(); // пустая строка
//Method21(count: 4, msg: "New text");

// * Type3

int Method3() // Аргументы не принимает, но возвращает
{
    return DateTime.Now.Year;
}

int year = Method3(); // идентификатору переменной присваиваем значение
//Console.WriteLine(year); // выводим на экран уже переменную

// * Type4

string Method4(int count, string text) // принимает переменные и возвращает значения. Может быть разных типов (int, string ...)
{
    int i = 0;
    string result = String.Empty; // Изначальный результат будет пустой строкой в
    // * которую мы запишем значение в цикле while. String.Empty может быть записана как ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
