
Console.WriteLine("Input user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "fox")
{
Console.WriteLine("Hey! It's you again!");
}
else
{
Console.Write("Hi, ");
Console.WriteLine(username);
}