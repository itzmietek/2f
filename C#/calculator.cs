
using System; 

public class Program 
{
    public static void Main(string[] args) 
    {
        string wynik = "wynik to : ";
        Console.WriteLine("Witaj w kalkulatorze!");
        Console.WriteLine("Podaj pierwszą liczbe");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj dzialanie  1 - dodawanie 2 - odejmowanie 3 - mnozenie 4 - dzielenie ");
        int dzialanie = int.Parse(Console.ReadLine());
        if (dzialanie == 1)
        {
            Console.WriteLine(wynik + (a+b));
            
        }
        else if (dzialanie == 2)
        {
            Console.WriteLine(wynik + (a-b));
            
        }
        else if (dzialanie == 3)
        {
            Console.WriteLine(wynik + (a*b));
        }
        else if (dzialanie ==4)
        {
            Console.WriteLine(wynik + (a/b));
        }
    }
}

