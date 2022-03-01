Console.WriteLine("Введите имя пользоватля: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура!!! Это Маша!!!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}