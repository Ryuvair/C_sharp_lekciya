Console.Write("Как вас зовут?");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Приевет,Маша, мы очень по тебе скучали!!!!"); 
}
else 
{
    Console.Write("Привет,");
    Console.Write(username);
}