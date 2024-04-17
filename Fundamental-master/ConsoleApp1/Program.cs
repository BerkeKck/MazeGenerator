// See https://aka.ms/new-console-template for more information

string kelime1, kelime2;
int sayi1, sayi2;


// Bu bir yorum Satiridir
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Bir kelime giriniz :");
kelime1 = Console.ReadLine();
Console.WriteLine("Baska bir  kelime giriniz :");
kelime2 = Console.ReadLine();

//Girilen Kelimeleri ekrana basalim
Console.WriteLine("Girilen Kelimeler " + kelime1 + " " + kelime2);


//Ekrani Beklemtmek icin yazildi
Console.ReadLine();
