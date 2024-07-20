



Console.WriteLine("Lütfen bir rakam giriniz:");
int sayi=Convert.ToInt32(Console.ReadLine());


if (sayi > 10 && sayi%2==0)
{
    Console.WriteLine("Girilen sayı 10dan büyük ve çifttir.");
}
else if (sayi > 10 && sayi % 2 == 1)
{
    Console.WriteLine("Girilen sayı 10dan büyük ve tekdir.");
}
else if (sayi < 10 && sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayı 10dan büyük ve çifttir.");
}
else if (sayi < 10 && sayi % 2 == 1)
{
    Console.WriteLine("Girilen sayı 10dan büyük ve tekdir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 10dur");
}