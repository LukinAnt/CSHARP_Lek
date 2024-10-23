// например для вывода копирайтинга в программе, ничего не принимает и не выдает
/* void Method1()
{
    System.Console.WriteLine("автор ...");
}
Method1();
*/

// 
/*
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("текст сообщения");
*/
/*void Method21(string msg, int count)
{
    int i =0;
    while (i < count)
    {
            System.Console.WriteLine(msg);
            i++;
    }
}
//Method21("текст", 4);
Method21(count: 4, msg: "нов текст");
*/

//3 grup
// чтото возвращают но ничего не принимают
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);
*/

// 4 вид. чтото принимают и чтото возвращают
/*string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(3, "ltbj");
System.Console.WriteLine(res);
*/
// перерабатываем 4 вариант для цыкла for
/*
string Method4(int count, string text)
{
    string result = String.Empty;
for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(3, "ltbj");
System.Console.WriteLine(res);
*/

// цикл в цикле - таблица умножения

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
    System.Console.WriteLine();
}
*/
// пробел на черночку
// к на К
// С на с

string text = " – Я думаю, – сказал князь, улыбаясь, – что, "
            + " ежели бы вас послали вместо нашего милого Винценгероде, "
            + " вы бы взяли приступом согласие прусского короля. "
            + " Вы так красноречивы. Вы дадите мне чаю? ";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);

System.Console.WriteLine();
newText = Replace(newText, 'с', 'С');
System.Console.WriteLine(newText);