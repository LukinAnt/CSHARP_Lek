// например для вывода копирайтинга в программе, ничего не принимает и не выдает
/* void Method1()
{
    System.Console.WriteLine("автор ...");
}
Method1();
*/

// 
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("текст сообщения");

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
string Method4(int count, string c)
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