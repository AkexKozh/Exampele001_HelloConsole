Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анастасия")
{
    Console.WriteLine("Ура, это же найденешь ");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
