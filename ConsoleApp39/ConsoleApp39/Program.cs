Console.WriteLine("consol arka plan rengini istediğiniz gibi yapınız (red-yellow-blue)");
string alınan = Console.ReadLine();
if (alınan == "red")
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("alınan değeri kırmızı olarak seçtiniz");

}
else if (alınan == "yellow")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("alınan değeri sarı olarak seçtiniz");

}
else if (alınan == "blue")
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("alınan değeri mavi olarak seçtiniz");
}
else
{
    Console.WriteLine("renk seçimi yapmadınız");
}