Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ruslan")
{
    Console.WriteLine("Asalam Aleykum, Ruslan");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(username);
}