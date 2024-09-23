Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

//if(username =="Маша")
if(username.ToLower() == "маша") //решение проблемы с регистром
{
    Console.WriteLine("Ура это же машка");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
