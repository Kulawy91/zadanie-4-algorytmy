using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tworzenie instancji kolejki
        KolejkaNapisow kolejkaNapisow = new KolejkaNapisow();

        // Dodawanie elementów do kolejki
        kolejkaNapisow.DodajElement("abc");
        kolejkaNapisow.DodajElement("123");
        kolejkaNapisow.DodajElement("XYZ");
        kolejkaNapisow.DodajElement("def");

        // Wyświetlanie zawartości kolejki
        Console.WriteLine("Zawartość kolejki:");
        foreach (var element in kolejkaNapisow)
        {
            Console.WriteLine(element);
        }

        // Wyszukiwanie elementu w kolejce
        string szukanyElement = "def";
        if (CzyElementIstniejeWKolejce(kolejkaNapisow, szukanyElement))
        {
            Console.WriteLine($"Element '{szukanyElement}' znajduje się w kolejce.");
        }
        else
        {
            Console.WriteLine($"Element '{szukanyElement}' nie został znaleziony w kolejce.");
        }
    }

    // Metoda sprawdzająca, czy element istnieje w kolejce
    static bool CzyElementIstniejeWKolejce(KolejkaNapisow kolejka, string szukanyElement)
    {
        return kolejka.ZawieraElement(szukanyElement);
    }
}

class KolejkaNapisow : Queue<string>
{
    // Dodawanie elementu do kolejki
    public void DodajElement(string element)
    {
        Enqueue(element);
    }

    // Metoda sprawdzająca, czy element istnieje w kolejce
    public bool ZawieraElement(string szukanyElement)
    {
        return Contains(szukanyElement);
    }
}
